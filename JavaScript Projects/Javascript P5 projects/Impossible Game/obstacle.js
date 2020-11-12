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
    fill(180);
    //rotate(HALF_PI / 3.0);
    rect(this.x, this.y, this.r, this.r);
  }
}
