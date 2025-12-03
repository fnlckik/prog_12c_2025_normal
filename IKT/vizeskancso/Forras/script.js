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
}
div.addEventListener("click", pour);