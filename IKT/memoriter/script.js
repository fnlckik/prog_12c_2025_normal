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
const missing = [];

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
        const p = randint(1, 100); // 23% valószínűséggel <input>
        if (p <= 23 && word !== "\n") {
            result += `<input type='text' size='${word.length}' maxlength='${word.length}'> `;
            missing.push(word.replace("\n", ""));
        } else {
            result += word + " ";
        }
        if (word[word.length-1] === "\n") {
            result += "<br>";
        }
    }
    return result;
}

// event.preventDefault()
const checkBtn = document.querySelector("#check");
function checkPoem(event) {
    if (event.type === "keyup" && event.key !== "Enter") return;
    console.log(event.type);
    const guessInputs = document.querySelectorAll("input[type='text']");
    for (let i = 0; i < guessInputs.length; i++) {
        if (guessInputs[i].value.toLowerCase() === missing[i].toLowerCase()) {
            guessInputs[i].style.backgroundColor = "lightgreen";
            guessInputs[i].readOnly = true;
        } else {
            guessInputs[i].style.backgroundColor = "pink";
        }
    }
}

const startBtn = document.querySelector("#start");
function startGame() {
    poemDiv.innerHTML = createPoem();
    poemDiv.classList.remove("d-none");
    startBtn.disabled = true;
    checkBtn.disabled = false;
    startBtn.removeEventListener("click", startGame);
    checkBtn.addEventListener("click", checkPoem);
    poemDiv.addEventListener("keyup", checkPoem);
}
startBtn.addEventListener("click", startGame);