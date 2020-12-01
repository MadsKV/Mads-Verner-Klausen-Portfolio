let isJumping = false;
let angle = 0.0;
let jitter = 0.0;
class Player {
  
  constructor() {
    this.r = 40;
    this.x = 170;
    this.y = height - this.r;
    this.v = 0;
    this.gravity = 8.5;

  }
  
  jump() {
    isJumping = true;
    var score = document.getElementById("p").textContent;
    score++;
    document.getElementById("p").innerHTML = score;
    this.v = -50;
  }
  
  isPlayerJumping() {
    //console.log("test" + this.y);
    if(this.y < height - (this.r)) //Tjekker højden, (dette er taget fra din egen if-sætning i Jump()
	{
    console.log("Is jumping" + this.y);
    return false; //Nej, vi er på jorden
	}
	else
	{
    console.log("Done jumping" + this.y);
    //this.y = height - this.r;
    //this.v = 0;
		return true; //Ja, vi er ved at hoppe
  }
  }
  animation() {
    this.playerAnimation();
  }
  playerAnimation() {
    //isJumping = this.isPlayerJumping();
    if (isJumping == true) {
      console.log("Jump");
      //translate(width / 2, height / 2);
      //rotate(PI / 3.0);
      
    }
  }

  hits(obstacles) {
    return collideRectRect(
      this.x,
      this.y,
      this.r,
      this.r,
      obstacles.x,
      obstacles.y,
      obstacles.r,
      obstacles.r
    );
  }
  move() {
    this.y += this.v;
    this.v += this.gravity;
    this.y = constrain(this.y, 0, height - this.r);
    
  }

  show() {
    push();
    rectMode(CENTER);
    translate(20, 20);
    //rotate(1 / 3.0);
    fill(33, 150, 243);
    rect(this.x, this.y, this.r, this.r);
    noStroke();
    pop();
  }
}
