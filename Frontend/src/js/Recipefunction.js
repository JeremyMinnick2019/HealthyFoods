import Recipe from "./components/EditRecipe"
import apiActions from "./api/apiActions"
import EditRecipe from "./components/EditRecipe"
export default () => {
    recipenav()
}

function recipenav(){
    const navRecipe = document.querySelector("#Recipe");
    navRecipe.addEventListener("click", function(){
        apiActions.getRequest("https://localhost:44339/api/Recipe", recipe => {
            document.querySelector("#app").innerHTML = Recipe(recipe);
            console.log(recipe);
        });
    });
}