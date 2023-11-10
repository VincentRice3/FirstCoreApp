// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function displayApp(app)
    {
        const appId = app;
        console.log(appId);
        switch(appId)
        {
            case "rice":
            document.getElementById(`app(${appId})`).innerHTML =
                ` <div class="appTextContent">
                    <h5> Convert uncooked rice to cooked! </h5>
                    <label for= "uncooked" > Uncooked Rice in grams: </label><br>
                    <div class="form">
                        <input type="number" class="form-control" id = "uncookedVal" name = "uncookedVal" value = "" >
                        <input type="button" class="btn btn-success " style="margin-left: 10px;" value = "Submit" onclick = "submitRequest(uncookedVal.value)" >
                    </div>
                    <a class="btn btn-primary" onClick="window.location.reload()">Close</a>
                    </div>`;
                break;
            case "colour":
                document.getElementById(`app(${appId})`).innerHTML =
                   `<div class="appTextContent">
                        <h5>Find your desired colour! </h5>
                        <p>Current Colour: #011936</p>
                        <label for= "colourPicker">Press the button for a new colour</label><br>
                        <input type="button" class="btn btn-success "value = "Submit" onclick = "changeColour()" >
                        <a class="btn btn-primary" onClick="window.location.reload()">Close</a>
                    </div>`;
        }
}

function submitRequest(form) {
    const inputValue = form;
    let conversion = inputValue * 3;
    let conversionResult = `Uncooked Rice amount = ${inputValue}g \nCooked conversion = ${conversion}g`;
    document.getElementById("conversion").innerText = conversionResult;
    document.getElementById("conversion").style.display = "inherit";
}


function changeColour() {
    const colour = getColour();
    document.getElementById(`app(colour)`).style.backgroundColor = colour;
    document.getElementById(`app(colour)`).innerHTML =
        `<div class="appTextContent">
                        <h5>Find your desired colour! </h5>
                        <p>Current Colour: ${colour}</p>
                        <label for= "colourPicker">Press the button for a new colour</label><br>
                        <input type="button" class="btn btn-success "value = "Submit" onclick = "changeColour()" >
                        <a class="btn btn-primary" onClick="window.location.reload()">Close</a>
                    </div>`;
}

const getColour = () => {
    const values = [ 'A', 'B', 'C', 'D', 'E', 'F', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' ];
    let hexValue = "#";
    for (i = 0; i < 6; i++)
    {
        let randomNumber = Math.floor(Math.random() * values.length);
        console.log(randomNumber);

        hexValue += values[randomNumber];

    }
    console.log(hexValue);
    return hexValue;
}
