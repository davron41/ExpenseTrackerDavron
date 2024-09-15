document.addEventListener('DOMContentLoaded', () => {
    document.querySelectorAll('.e-menu-item').forEach(link => {
        console.log(location.pathname.toLowerCase(), link.textContent, (location.pathname.toLowerCase().endsWith(link.textContent.toLowerCase())));
        if (location.pathname.toLowerCase().endsWith(link.textContent.toLowerCase())) {
            link.classList.add('active-menu-item');
            console.log(link);
        } else {
            link.classList.remove('active-menu-item');
        }
    });
})