export default function Recipe(recipe) {
    return `

    <section class='add-Recipe'>
    <input class='add-Title' type='text' placeholder='Add A Title'>
    <input class='add-Calorie' type='text' placeholder='Add how much calories it is'>
    <input class='add-Instructions' type='text' placeholder='Add instructions for the recipe'>
    <button class='add-Recipe_submit'>Submit</button>
  </section>

<section id="Recipe-setup">    
<ul> 
    ${recipe
      .map(recipePage => {
        return `
             <li class="recipe-list" id="recipe">
                <h2>${recipePage.title}</h2>
                <img src=${recipePage.image} class="albumIMG"></img>
                <h4>${recipePage.calorie}</h4>
                <p>${recipePage.instructions}</p>
                <p><input class="recipe_id" type="hidden" value="${recipePage.id}"></p>
                <button class="edit-Recipe_submit">Edit</button>
                <button class="delete-Recipe_submit">Delete</button>
             </li>
        `;
      })
      .join("")}
 </ul>
    `;
}