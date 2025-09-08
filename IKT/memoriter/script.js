// const title = document.getElementById("title");

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

const startBtn = document.querySelector("#start");
// startBtn.onclick = startGame;
function startGame() {
    poemDiv.innerText = poem;
    poemDiv.classList.remove("d-none");
    // poemDiv.className = "";
    // poemDiv.removeAttribute("class");
    // startBtn.setAttribute("disabled", "true");
    startBtn.disabled = true;
    startBtn.removeEventListener("click", startGame);
}
startBtn.addEventListener("click", startGame);