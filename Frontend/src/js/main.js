import Nav from "./components/Nav"

export default () => {
    pageBuild()
}

function pageBuild(){
    nav();
}

function nav(){
    const nav = document.getElementById("nav")
    nav.innerHTML = Nav()
}