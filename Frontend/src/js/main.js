import Nav from "./components/Nav"
import apiActions from "./api/apiActions"
import MainIngredient from "./components/MainIngredient"
import MealType from "./components/MealType"

export default () => {
    pageBuild()
}

function pageBuild(){
    nav();
    mainingredientnav();
    MealTypenav();
}

function nav(){
    const nav = document.getElementById("nav")
    nav.innerHTML = Nav()
}

function mainingredientnav(){
    const navMainIngredient = document.querySelector("#MainIngredient");
    navMainIngredient.addEventListener("click", function(){
        apiActions.getRequest("https://localhost:44339/api/MainIngredient", mainingredient => {
            document.querySelector("#app").innerHTML = MainIngredient(mainingredient);
            console.log(mainingredient);
        });
    });
}

function MealTypenav(){
    const navMealType = document.querySelector("#MealType");
    navMealType.addEventListener("click", function(){
        apiActions.getRequest("https://localhost:44339/api/MealType", mealtype => {
            document.querySelector("#app").innerHTML = MealType(mealtype);
            console.log(mealtype);
        });
    });
}