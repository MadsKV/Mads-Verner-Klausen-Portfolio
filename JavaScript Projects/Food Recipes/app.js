const searchForm = document.querySelector("form");
const searchResultDiv = document.querySelector(".search-result");
const container = document.querySelector(".container");
let searchQuery = "";
const APP_ID = "f91f2095";
const APP_KEY = "6f19873efc9792d54d5d0f9faed1a3c3";

searchForm.addEventListener("submit", (e) => {
  e.preventDefault();
  searchQuery = e.target.querySelector("input").value;
  fetchAPI();
});

async function fetchAPI() {
  const baseURL = `https://api.edamam.com/search?q=${searchQuery}&app_id=${APP_ID}&app_key=${APP_KEY}&to=100`;
  const response = await fetch(baseURL);
  const data = await response.json();
  generateHTML(data.hits);
  console.log(data);
}
function generateHTML(results) {
  container.classList.remove("initial");
  let generatedHTML = "";
  results.map((result) => {
    generatedHTML += `
      <div class="item">
                    <img src="${result.recipe.image}" alt="">
                    <div class="flex-container">
                        <h1 class="title">${result.recipe.label}</h1>
                        <a class="view-button" href="${
                          result.recipe.url
                        }" target="_blank">View Recipe</a>
                    </div>
                    <p class="item-data">Calories: ${result.recipe.calories.toFixed(
                      2
                    )}</p>
                    <p class="item-data">Diet label: ${
                      result.recipe.dietLabels.length > 0
                        ? result.recipe.dietLabels
                        : "No Data Found"
                    }</p>
                    <p class="item-data">Cuisine:  ${
                      result.recipe.cuisineType
                    }</p>
                    </p>
                    </p>
                    <p class="item-data">Type:  ${
                      result.recipe.mealType
                    }</p>
                    </p>
                    <p class="item-data">Time to make:  ${
                      result.recipe.totalTime > 0 ? result.recipe.totalTime : " "
                    }</p>
                    
                </div>
      `;
  });
  searchResultDiv.innerHTML = generatedHTML;
}
