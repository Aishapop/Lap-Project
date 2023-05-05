// Select the navigation links and the main content area
const navLinks = document.querySelectorAll('nav ul li a');
const mainContent = document.querySelector('main');

// Add an event listener to each navigation link
navLinks.forEach(link => {
  link.addEventListener('click', e => {
    e.preventDefault(); // Prevent the default link behavior
    const href = link.getAttribute('href'); // Get the href attribute
    const offsetTop = document.querySelector(href).offsetTop; // Get the offsetTop of the section
    window.scrollTo({
      top: offsetTop,
      behavior: 'smooth' // Smooth scroll to the section
    });
  });
});
