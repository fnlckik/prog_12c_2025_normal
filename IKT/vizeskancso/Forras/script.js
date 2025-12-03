const MAXLEFT = 9;
const MAXRIGHT = 4;

// let left = 0; // Bal oldali aktuális mennyisége
// let right = 0; // Jobb oldali aktuális mennyisége

// const leftFill = document.querySelector("#left-fill");
const div = document.querySelector(".container");
function fill(e) {
    // if (e.target.id !== "left-fill" && e.target.id !== "right-fill") return;
    const button = e.target;
    if (button.id.split("-")[1] !== "fill") return;
    // button.parentNode.children[0]
    // button.parentNode.firstElementChild
    const table = button.parentNode.querySelector("table");
    const rows = table.rows;
    // const amount = MAXRIGHT;
    const amount = button.id.split("-")[0] == "left" ? MAXLEFT : MAXRIGHT;
    fillRows(rows, amount);
}
// leftFill.addEventListener("click", fill);
div.addEventListener("click", fill);

// Feltölti a kapott rows sorokat alulról 
// kezdve amount mennyiségű vízzel.
function fillRows(rows, amount) {
    // Ürítem az aktuális táblázat sorait.
    for (const tr of rows) {
        tr.classList.remove("filled");
    }
    // Elvégzem a feltöltést.
    const n = rows.length;
    for (let i = n - 1; i > n-1-amount; i--) {
        rows[i].classList.add("filled");
    }
}

function pour(e) {
    const button = e.target;
    if (button.id.split("-")[1] !== "pour") return;
    
    const div = button.parentNode;
    const currentTable = div.querySelector("table");
    let currentFilled = currentTable.querySelectorAll(".filled").length;
    
    let otherTable;
    if (div.id === "left") {
        otherTable = document.querySelector("#right table");
    } else {
        otherTable = document.querySelector("#left table");
    }
    let otherFilled = otherTable.querySelectorAll(".filled").length;
    const free = otherTable.querySelectorAll("tr").length - otherFilled;
    const amount = Math.min(currentFilled, free);
    // console.log(currentFilled, otherFilled, free, amount);
    currentFilled -= amount;
    otherFilled += amount;
    fillRows(currentTable.rows, currentFilled);
    fillRows(otherTable.rows, otherFilled);
    if (currentFilled === 6 || otherFilled === 6) {
        const winDiv = document.querySelector("#win");
        winDiv.style.display = "block";
    }
}
div.addEventListener("click", pour);

function clear(e) {
    const button = e.target;
    if (button.id.split("-")[1] !== "clear") return;
    const div = button.parentNode;
    const currentTable = div.querySelector("table");
    let currentFilled = currentTable.querySelectorAll(".filled").length;
    currentFilled = 0;
    fillRows(currentTable.rows, currentFilled);
}
div.addEventListener("click", clear);

const table = document.querySelector("#test");
function showCell(e) {
    const td = e.target;
    const j = td.cellIndex;
    const tr = td.parentNode;
    const i = tr.rowIndex;
    console.log(`(${i}, ${j})`);
}
table.addEventListener("click", showCell);

// Random szám generálás [a..b]-on.
function randint(a, b) {
    return Math.floor(Math.random() * (b-a+1)) + a;
}

function randomize(e) {
    if (e.code !== "KeyR") return;
    const n = table.rows.length;
    const m = table.rows[0].cells.length;
    const i = randint(0, n-1);
    const j = randint(0, m-1);
    const td = table.rows[i].cells[j];
    td.innerText = "alma";
}
window.addEventListener("keyup", randomize);