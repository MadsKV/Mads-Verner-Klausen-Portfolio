let player;
let obstacles = []

let restartButton;

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
  
  background(119,136,153);
  if (random(1) < 0.010) {
    temp = new Obstacle()
    obstacles.push(temp);
    console.log(temp);
  }
  
  for (let i of obstacles) {
    i.show_obs();
    i.move_obs();
    if (player.hits(i)) {
      background(230, 0, 0);
      console.log("Game Over");
      noLoop();
    }
  }
  player.show();
  player.move();


}
