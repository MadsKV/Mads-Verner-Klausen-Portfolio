class Obstacle {
  constructor() {
    this.r = 35;
    this.x = width;
    this.y = height - this.r;
  }

  move_obs() {
    this.x -= 15;
  }

  show_obs() {
    push();
    translate(20, 15);
    rect(this.x, this.y, this.r, this.r);
    fill(180);
    pop();
    //rotate(HALF_PI / 3.0);
  }
}
