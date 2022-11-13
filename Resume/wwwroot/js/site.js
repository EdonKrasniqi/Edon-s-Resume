// This function is about active dots when you scroll, it will activate in the specific section of the page.
function updateList() {
    const titles = [...document.querySelectorAll('h1, h2')].sort((a, b) => {
        return Math.abs(a.getBoundingClientRect().top) - Math.abs(b.getBoundingClientRect().top);
    });

    document.querySelectorAll(".active").forEach(c => c.classList.remove("active"));

    document.querySelectorAll(".nav-dot")[[...document.querySelectorAll('h1, h2')].indexOf(titles[0])].classList.add("active");
}

updateList();
window.addEventListener('scroll', () => {
    updateList();
})