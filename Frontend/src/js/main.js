import Nav from "./components/Nav"
import apiActions from "./api/apiActions"
import MainIngredient from "./components/MainIngredient"

export default () => {
    pageBuild()
}

function pageBuild(){
    nav();
    mainingredientnav();
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