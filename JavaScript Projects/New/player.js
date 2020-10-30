class Player {
    constructor() {
        this.r = 40;
        this.x = 170;
        this.y = height - this.r;
        this.v = 0;
        this.gravity = 8.5;
    }
    jump() {
        if (this.y == height - this.r){
            this.v = -40;
        }
    }

    hits(obstacles) {
        return collideRectRect(this.x, this.y, this.r, this.r, obstacles.x, obstacles.y, obstacles.r, obstacles.r);
    }
    move() {
        this.y += this.v;
        this.v += this.gravity;
        this.y =constrain(this.y, 0, height - this.r);
    }


    show() {
        fill(33, 150, 243);
        noStroke();
        //translate (width/2, height/2);
        //rotate(PI / 3.0);
        
        rect(this.x, this.y, this.r, this.r);
   }
}