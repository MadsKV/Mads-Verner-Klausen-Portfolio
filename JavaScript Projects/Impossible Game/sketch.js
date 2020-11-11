let player;
let obstacles = [];
let restartButton;
let isJumping = false;
var endAudio = new Audio("EndSound.mp3");
const audio = document.querySelector("#music_list audio");
//var audio = new Audio('Ninjaneers -I just wanna smile.mp3');
//var audio2 = new Audio('Syn Cole - Feel Good.mp3');

//Gives the player the "Start Button" to activate the game/sound files/obstacles.
function startGame() {
  document.getElementById("StartBtn").style.display = "none";
}
//Creates the array of gamesounds(songs).
function setupAudio() {
  var audioFiles = [
    "Caramella Girls - Caramelldansen Swedish Original (Official).mp3",
    "Fox Stevenson - Go Like (D&B Mix).mp3",
    "Ninjaneers -I just wanna smile.mp3",
    "Syn Cole - Feel Good.mp3",
    "Alan Walker - Spectre.mp3",
    "DEAF KEV - Invincible.mp3",
  ];

  var i = 0;
  //Renames the music list -> music_player
  var music_player = document.querySelector("#music_list audio");
  //Checks if the current song have stopped playing and then moves to the next song in the array.
  function next() {
    if (i === audioFiles.length - 1) {
      i = 0;
    } else {
      i++;
    }

    music_player.src = audioFiles[i];
  }
  //Checks if the HTML audio player is available, if it is, play the songs in the array, if not dont play.
  if (music_player === null) {
    throw "Playlist Player does not exists ...";
  } else {
    music_player.src = audioFiles[i];

    music_player.addEventListener("ended", next, false);
  }
}
//Preloads the songs when opening the browser.
function preload() {
  setupAudio();
  next();
}
//creates the canvas and declares the classes.
function setup() {
  createCanvas(1535, 600);
  player = new Player();
  obstacle = new Obstacle();
}
//Makes the spacebar the jump function, also uses the "player" class to check if the player is currently jumping.
function keyPressed() {
  if (key == " ") {
    player.isPlayerJumping();
    player.jump();
  }
}
//Draws the background, player and obstacles. The obstacles are spawning in randomly every 10% of the time.
function draw() {
  background(3, 19, 33);
  if (random(1) < 0.01) {
    temp = new Obstacle();
    obstacles.push(temp);
    console.log(temp);
  }
  player.show();
  player.move();

  gameOver();
}
//checks if the player have hit one of the obstacles. If he have, stop the game, audio and start playing the end-song also shows the restart button.
function gameOver() {
  for (let i of obstacles) {
    i.show_obs();
    i.move_obs();
    if (player.hits(i)) {
      background(0, 0, 0);
      document.getElementById("restartBtn").style.display = "inline-block";
      console.log("Game Over");
      audio.pause();
      audio.currentTime = 0;
      endAudio.play();
      noLoop();
    }
  }
}
