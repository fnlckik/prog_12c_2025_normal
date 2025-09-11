// Globális változók!
const poem = 
`Isten, áldd meg a magyart
Jó kedvvel, bőséggel,
Nyújts feléje védő kart,
Ha küzd ellenséggel;
Bal sors akit régen tép,
Hozz rá víg esztendőt,
Megbünhödte már e nép
A multat s jövendőt!

Őseinket felhozád
Kárpát szent bércére,
Általad nyert szép hazát
Bendegúznak vére.
S merre zúgnak habjai
Tiszának, Dunának,
Árpád hős magzatjai
Felvirágozának.`;

const poemDiv = document.querySelector("#poem");
const words = poem.replaceAll("\n", "\n ").split(" ");

// [a..b]-on random számok
// [3..7] => 7 - 3 + 1 
// Hány fajta szám? b - a + 1
// Legkisebb szám? a
function randint(a, b) {
    return Math.floor(Math.random()*(b - a + 1)) + a;
}

// Játék működése
function createPoem() {
    let result = "";
    for (const word of words) {
        result += word + " ";
        if (word[word.length-1] === "\n") {
            result += "<br>";
        }
    }
    return result;
}

const startBtn = document.querySelector("#start");
function startGame() {
    poemDiv.innerHTML = createPoem();
    poemDiv.classList.remove("d-none");
    startBtn.disabled = true;
    startBtn.removeEventListener("click", startGame);
}
startBtn.addEventListener("click", startGame);