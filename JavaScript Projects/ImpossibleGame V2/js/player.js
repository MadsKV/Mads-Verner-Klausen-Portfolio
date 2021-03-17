class Player{
    constructor(x, y, v, color){
        this.r = 40;
        this.x = x
        this.y = y
        this.v = v
        this.color = color
    }
    draw(){
        ctx.beginPath()
        ctx.rect(20, 20, 150, 100);
        ctx.fillStyle = this.color
        ctx.fillRect(50, 50, 50, 50);
    }
}



const x = Canvas.width / 2
const y = Canvas.height / 2


const player = new Player (x, y, 'black')
player.draw()

console.log(player)
console.log(canvas)