let left = 3;

const leftFill = document.querySelector("#left-fill");
function fill() {
    const table = document.querySelector("#left table");
    const rows = table.rows;
    const n = rows.length;
    for (let i = n - 1; i > n-1-left; i--) {
        rows[i].classList.add("filled");
    }
}
leftFill.addEventListener("click", fill);