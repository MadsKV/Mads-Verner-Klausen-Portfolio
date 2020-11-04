let player;
let obstacles = []
let restartButton;
var audio = new Audio('Gamesound.mp3');

function preload() {
  audio.play();
  
}

function setup() {
  createCanvas(1535, 600);
  player = new Player();
  obstacle = new Obstacle();
}

function keyPressed() {
  if (key == ' ') {
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
  
  for (let i of obstacles) {
    i.show_obs();
    i.move_obs();
    if (player.hits(i)) {
      background(0, 0, 0);
      console.log("Game Over");
      audio.pause();
      audio.currentTime = 0;
      document.getElementById('restartBtn');
      noLoop();
    }
  }
  player.show();
  player.move();
}

function gameOver() {
  audio.currentTime = 0;

}
