import MainIngredient from "./components/MainIngredient"
import apiActions from "./api/apiActions"
import EditMainIngredient from "./components/EditMainIngredient"
export default () => {
    mainingredientnav()
}

function mainingredientnav(){
    const navMainIngredient = document.querySelector("#MainIngredient");
    navMainIngredient.addEventListener("click", function(){
        apiActions.getRequest('https://localhost:44339/api/MainIngredient', mainingredient => {
            document.querySelector("#app").innerHTML = MainIngredient(mainingredient);
            console.log(mainingredient);
        });
    });

const app = document.querySelector("#app")
app.addEventListener("click", function() {
    if(event.target.classList.contains("delete-MainIngredient_submit")) {
        const mainingredientid = event.target.parentElement.querySelector(".mainingredient_id").value;
        console.log("delete" + mainingredientid);
        apiActions.deleteRequest(`https://localhost:44339/api/MainIngredient/${mainingredientid}`,
        mainingredients => {
                app.innerHTML = MainIngredient(mainingredients);
            })       
    }
});

app.addEventListener("click", function() {
    if(event.target.classList.contains("edit-MainIngredient_submit")) {
        const mainingredientId = event.target.parentElement.querySelector(".mainingredient_id").value;
        console.log("edit" + mainingredientId);
        apiActions.getRequest(`https://localhost:44339/api/MainIngredient/${mainingredientId}`, MainIngredientEDIT => {
                app.innerHTML = EditMainIngredient(MainIngredientEDIT);
        })        
    }
});

app.addEventListener("click", function() {
    if(event.target.classList.contains("update-MainIngredient_submit")) {
    const mainingredientId = event.target.parentElement.querySelector(
        ".update-MainIngredient_id").value;
    const MainIngredientIngredient = event.target.parentElement.querySelector(
        ".update-mainingredient_ingredient").value;
        const mainingredientImage = event.target.parentElement.querySelector(
            ".MainIngredientImage").value;
    const mainingredientData = {
        id: mainingredientId,
        ingredient: MainIngredientIngredient,
        Image: mainingredientImage
    };

    apiActions.putRequest(
        `https://localhost:44339/api/MainIngredient/${mainingredientId}`,
        mainingredientData,
        mainingredients => {
        document.querySelector("#app").innerHTML = MainIngredient(mainingredients);
        })
    }
});

app.addEventListener("click", function(){
    if(event.target.classList.contains("add-MainIngredient_submit")){
        const addIngredient = event.target.parentElement.querySelector(
            ".add-Ingredients"        
        ).value;
        console.log(addIngredient);
        apiActions.postRequest
        (`https://localhost:44339/api/MainIngredient`, 
        {
            Ingredient: addIngredient
        },
        Ingredient => {
            console.log(Ingredient);
            document.querySelector("#app").innerHTML = MainIngredient(Ingredient);
        }
        )    
    }
});

}




