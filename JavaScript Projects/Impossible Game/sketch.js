let player;
let obstacles = []
let restartButton;
let isJumping = false;
var endAudio = new Audio('EndSound.mp3');
const audio = document.querySelector("#music_list audio");
//var audio = new Audio('Ninjaneers -I just wanna smile.mp3');
//var audio2 = new Audio('Syn Cole - Feel Good.mp3');

function startGame() {
  document.getElementById("StartBtn").style.display="none";
  
}

function setupAudio() {
  var audioFiles = [
      'Fox Stevenson - Go Like (D&B Mix).mp3',
      'Ninjaneers -I just wanna smile.mp3',
      'Syn Cole - Feel Good.mp3',
      'Alan Walker - Spectre.mp3',
      'DEAF KEV - Invincible.mp3'
  ];

  var i = 0;

  var music_player = document.querySelector("#music_list audio");

  function next() {
      if (i === audioFiles.length - 1) {
          i = 0;
      } else {
          i++;
      }

      music_player.src = audioFiles[i];
  }

  if (music_player === null) {
      throw "Playlist Player does not exists ...";
  } else {
      music_player.src = audioFiles[i];

      music_player.addEventListener('ended', next, false)
  }

};

function preload() {
  setupAudio()
  next();
}

function setup() {
  createCanvas(1535, 600);
  player = new Player();
  obstacle = new Obstacle();
}

function keyPressed() {
  if (key == ' ') {
    player.isPlayerJumping();
    player.jump();
  }
}

function draw() {
  background(3, 19, 33);
  if (random(1) < 0.010) {
    temp = new Obstacle()
    obstacles.push(temp);
    console.log(temp);
  }
  player.show();
  player.move();

  gameOver();
}

function gameOver() {
  
  
  for (let i of obstacles) {
    i.show_obs();
    i.move_obs();
    if (player.hits(i)) {
      background(0, 0, 0);
      document.getElementById("restartBtn").style.display="inline-block";
      console.log("Game Over");
      audio.pause();
      audio.currentTime = 0;
      endAudio.play();
      noLoop();
    }
  }
}
