/*--------------------------- Dinosour Jump Start  ----------------------------*/
const dino = document.getElementById("dino");
const cactus = document.getElementById("cactus");
var score = document.getElementById("score");
var point = 0;
function jump() {
    if (dino.classList != "jump") {
        dino.classList.add("jump");

        setTimeout(function () {
            dino.classList.remove("jump");
        }, 300);
    }
}
setInterval(function () {
    point += 1;
    score.innerHTML = "Score :" + point;
}, 500);
let isAlive = setInterval(function () {
    // get current dino Y position
    let dinoTop = parseInt(window.getComputedStyle(dino).getPropertyValue("top"));

    // get current cactus X position
    let cactusLeft = parseInt(
        window.getComputedStyle(cactus).getPropertyValue("left")
    );

    // detect collision
    if (cactusLeft < 50 && cactusLeft > 0 && dinoTop >= 140) {
        // collision
        cactus.classList.remove("movement");
        alert("Game Over! Score is "+point);
        cactus.classList.add("movement");
        point = 0;
    }
}, 10);

document.addEventListener("keydown", function (event) {
    jump();
});
/*--------------------------- Dinosour Jump End  ----------------------------*/
/*--------------------------- Flappy Bird Start  ----------------------------*/

/*--------------------------- Flappy Bird End    ----------------------------*/