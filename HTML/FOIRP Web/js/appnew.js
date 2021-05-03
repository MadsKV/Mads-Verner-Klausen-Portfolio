// Select the button
const btn = document.querySelector(".btn-toggle");
// Select the stylesheet <link>
const theme = document.querySelector("#theme-link");

// Listen for a click on the button
btn.addEventListener("click", function () {
  // If the current URL contains "dark-theme.css"
  if (theme.getAttribute("href") == "/HTML/FOIRP Web/css/stylesheet-dark.css") {
    // ... then switch it to "light-theme.css"
    theme.href = "/HTML/FOIRP Web/css/stylesheet-light.css";
    // Otherwise...
  } else {
    // ... switch it to "dark-theme.css"
    theme.href = "/HTML/FOIRP Web/css/stylesheet-dark.css";
  }
});

