import Nav from "./components/Nav"
import apiActions from "./api/apiActions"
import MealType from "./components/MealType"
import Recipe from "./components/Recipe"
import mainingredientnav from "./MainIngredientsfunctions"
import MainIngredient from "./components/MainIngredient"
import EditMainIngredient from "./components/EditMainIngredient"
import EditMealType from "./components/EditMealType"
import EditRecipe from "./components/EditRecipe"

export default () => {
    pageBuild()
}

function pageBuild(){
    nav();
    mainingredientnav();
    mealtypenav();
    recipenav();
    mainingredient();
}

function nav(){
    const nav = document.getElementById("nav")
    nav.innerHTML = Nav()
}

function mainingredient() {
    mainingredientnav()
}

/* start of mealtype */

function mealtypenav(){
    const navMealType = document.querySelector("#MealType");
    navMealType.addEventListener("click", function(){
        apiActions.getRequest('https://localhost:44339/api/MealType', mealtype => {
            document.querySelector("#app").innerHTML = MealType(mealtype);
            console.log(mealtype);
        });
    });

    const app = document.querySelector("#app")
    app.addEventListener("click", function() {
    if(event.target.classList.contains("delete-MealType_submit")) {
        const mealtypeid = event.target.parentElement.querySelector(".mealtype_id").value;
        console.log("delete" + mealtypeid);
        apiActions.deleteRequest(`https://localhost:44339/api/MealType/${mealtypeid}`,
        mealtypes => {
                app.innerHTML = EditMealType(mealtypes);
            })       
    }
});

app.addEventListener("click", function() {
    if(event.target.classList.contains("edit-MealType_submit")) {
        const mealtypeid = event.target.parentElement.querySelector(".mealtype_id").value;
        console.log("edit" + mealtypeid);
        apiActions.getRequest(`https://localhost:44339/api/MealType/${mealtypeid}`, MealTypeEDIT => {
                app.innerHTML = EditMealType(MealTypeEDIT);
        })        
    }
});

app.addEventListener("click", function() {
    if(event.target.classList.contains("update-MealType_submit")) {
    const mealtypeid = event.target.parentElement.querySelector(
        ".update-MealType_id").value;
    const mealtypeType = event.target.parentElement.querySelector(
        ".update-MealType_type").value;
    const mealtypeData = {
        id: mealtypeid,
        type: mealtypeType,
    };

    apiActions.putRequest(
        `https://localhost:44339/api/MealType/${mealtypeid}`,
        mealtypeData,
        mealtypes => {
        document.querySelector("#app").innerHTML = MainIngredient(mealtypes);
        })
    }
});

app.addEventListener("click", function(){
    if(event.target.classList.contains("add-MealType_submit")){
        const addMealtype = event.target.parentElement.querySelector(
            ".update-MealType_type").value;
        console.log(addMealtype);
        apiActions.postRequest
        (`https://localhost:44339/api/MealType`, 
        {
            type: addMealtype
        },
        type => {
            console.log(type);
            document.querySelector("#app").innerHTML = MealType(type);
        }
        )    
    }
});

/* start of recipe */

}

function recipenav(){
    const navRecipe = document.querySelector("#Recipe");
    navRecipe.addEventListener("click", function(){
        apiActions.getRequest("https://localhost:44339/api/Recipe", recipe => {
            document.querySelector("#app").innerHTML = Recipe(recipe);
            console.log(recipe);
        });
    });
    const app = document.querySelector("#app")
    app.addEventListener("click", function() {
    if(event.target.classList.contains("delete-Recipe_submit")) {
        const recipeid = event.target.parentElement.querySelector(".recipe_id").value;
        console.log("delete" + recipeid);
        apiActions.deleteRequest(`https://localhost:44339/api/MealType/${recipeid}`,
        recipes => {
                app.innerHTML = EditMealType(recipes);
            })       
    }
});

app.addEventListener("click", function() {
    if(event.target.classList.contains("edit-Recipe_submit")) {
        const recipeid = event.target.parentElement.querySelector(".recipe_id").value;
        console.log("edit" + recipeid);
        apiActions.getRequest(`https://localhost:44339/api/MealType/${recipeid}`, RecipeEDIT => {
                app.innerHTML = EditRecipe(RecipeEDIT);
        })        
    }
});

app.addEventListener("click", function() {
    if(event.target.classList.contains("update-Recipe_submit")) {
    const RecipeTitle = event.target.parentElement.querySelector(
        ".update-Recipe_Title").value;
    const RecipeCalorie = event.target.parentElement.querySelector(
        ".update-Recipe_Calorie").value;
    const RecipeInstructions = event.target.parentElement.querySelector(
        ".update-Recipe_Instructions").value;
    const Recipeid = event.target.parentElement.querySelector(
        ".update-Recipe_id").value;
    const RecipeImage = event.target.parentElement.querySelector(
        ".RecipeImage").value;
    const recipeData = {
        id: Recipeid,
        title: RecipeTitle,
        calorie: RecipeCalorie,
        instructions: RecipeInstructions,
        image: RecipeImage

    };

    apiActions.putRequest(
        `https://localhost:44339/api/MealType/${recipeid}`,
        recipeData,
        recipes => {
        document.querySelector("#app").innerHTML = MainIngredient(recipes);
        })
    }
});

app.addEventListener("click", function(){
    if(event.target.classList.contains("add-Recipe_submit")){
        const addTitle = event.target.parentElement.querySelector(
            ".add-Title").value;
        const addCalorie = event.target.parentElement.querySelector(
            ".add-Calorie").value;
        const addInstructions = event.target.parentElement.querySelector(
            ".add-Instructions").value;
        console.log(addTitle);
        apiActions.postRequest
        (`https://localhost:44339/api/Recipe`, 
        {
            title: addTitle,
            calorie: addCalorie,
            instructions: addInstructions

        },
        recipes => {
            console.log(recipes);
            document.querySelector("#app").innerHTML = EditRecipe(recipes);
        }
        )    
    }
});
}