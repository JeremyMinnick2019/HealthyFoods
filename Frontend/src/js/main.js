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
    mealtype();
    recipe();
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
        const idmainingredient = event.target.parentElement.querySelector(
            ".update-MealType_MainIngredientId").value;
    const mealtypeData = {
        id: mealtypeid,
        type: mealtypeType,
        mainingredientId: idmainingredient
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
            ".add-MealType"        
        ).value;
        console.log(addMealtype);
        apiActions.postRequest
        (`https://localhost:44339/api/MealType`, 
        {
            Type: addMealtype
        },
        Type => {
            console.log(Type);
            document.querySelector("#app").innerHTML = MealType(Type);
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
}