var email = document.getElementById("emailTB");
var material = document.getElementById("materialDD");
var width = document.getElementById("widthTB");
var height = document.getElementById("heightTB");
var description = document.getElementById("descriptionTA");
var submitButton = document.getElementById("submitQuoteForm");

var ValidateQuoteForm = function ()
{
    if (email.value.length < 5)
        email.setCustomValidity("Please enter a valid email.");
    else email.setCustomValidity("");

    if (material.value === "Select a material...")
        material.setCustomValidity("Please choose a valid material.");
    else material.setCustomValidity("");

    if (isNaN(width.value) || width.value.length === 0)
        width.setCustomValidity("Please enter a valid width.");
    else width.setCustomValidity("");

    if (isNaN(height.value) || height.value.length === 0)
        height.setCustomValidity("Please enter a valid height.");
    else height.setCustomValidity("");

    if (description.value.length < 5)
        description.setCustomValidity("Please enter a description.");
    else description.setCustomValidity("");
}

email.onkeyup = ValidateQuoteForm;
material.onchange = ValidateQuoteForm;
width.onkeyup = ValidateQuoteForm;
height.onkeyup = ValidateQuoteForm;
description.onkeyup = ValidateQuoteForm;
submitButton.onclick = ValidateQuoteForm;