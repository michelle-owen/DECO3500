function gridColourToggle() {
    //alert('hello world');

    var button = document.getElementById('blank-cell').style.backgroundColor;
    var color = '';
        
    if (button !== 'brown') {
        color = 'brown';
        document.getElementById('blank-cell').style.backgroundColor = color;
    } else if (button === 'brown') {
        color = 'red';
        document.getElementById('blank-cell').style.backgroundColor = color;
    }
}

function gridToggle(id) {
    
    var button = document.getElementById(id).style.backgroundColor;
    var color = '';
    
    if (button !== 'grey' && button !== 'red') {
        color = 'grey';
        document.getElementById(id).style.backgroundColor = color;
    } else if (button === 'grey') {
        color = 'red';
        document.getElementById(id).style.backgroundColor = color;

    } else if (button === 'red') {
        color = '#ededed';
        document.getElementById(id).style.backgroundColor = color;

    }
}

function gridToggleObstacleChange3(id) {
        
    //toggle grid colour as usual
    gridToggle(id);
    
    //as well as toggling the colour of the current tile, the PINK obstacle will be moved one tile right
    document.getElementById('R5C12').style.backgroundColor = '#ee6d89';
    document.getElementById('R5C6').style.backgroundColor = '#ededed';
    
    document.getElementById('R5C12').disabled = true;
    document.getElementById('R5C6').disabled = false;
}

function gridToggleObstacleChange2(id) {
    
    //toggle grid colour as usual
    gridToggle(id);
    
    //as well as toggling the colour of the current tile, the BLUE obstacle will be moved one tile right
    document.getElementById('R2C5').style.backgroundColor = '#6dc5ee';
    document.getElementById('R7C5').style.backgroundColor = '#ededed';
    
    document.getElementById('R2C5').disabled = true;
    document.getElementById('R7C5').disabled = false;
}

function gridToggleObstacleChange1(id) {
    
    //toggle grid colour as usual
    gridToggle(id);
    
    
    //as well as toggling the colour of the current tile, both ORANGE obstructions slide to the right by one tile
    document.getElementById('R1C4').style.backgroundColor = '#ee946d';
    document.getElementById('R2C4').style.backgroundColor = '#ee946d';
    document.getElementById('R3C4').style.backgroundColor = '#ee946d';
    
    document.getElementById('R1C3').style.backgroundColor = '#ededed';
    document.getElementById('R2C3').style.backgroundColor = '#ededed';
    document.getElementById('R3C3').style.backgroundColor = '#ededed';
    
    document.getElementById('R1C4').disabled = true;
    document.getElementById('R2C4').disabled = true;
    document.getElementById('R3C4').disabled = true;

    document.getElementById('R1C3').disabled = false;
    document.getElementById('R2C3').disabled = false;
    document.getElementById('R3C3').disabled = false;

    document.getElementById('R1C8').style.backgroundColor = '#ee946d';
    document.getElementById('R2C8').style.backgroundColor = '#ee946d';
    document.getElementById('R3C8').style.backgroundColor = '#ee946d';
    
    document.getElementById('R1C7').style.backgroundColor = '#ededed';
    document.getElementById('R2C7').style.backgroundColor = '#ededed';
    document.getElementById('R3C7').style.backgroundColor = '#ededed';
    
    document.getElementById('R1C8').disabled = true;
    document.getElementById('R2C8').disabled = true;
    document.getElementById('R3C8').disabled = true;

    document.getElementById('R1C7').disabled = false;
    document.getElementById('R2C7').disabled = false;
    document.getElementById('R3C7').disabled = false;
    
    
}

function gridToggleObstacleChange4(id) {
    
    //toggle grid colour as usual
    gridToggle(id);
    
    //as well as toggling the colour of the current tile, the PURPLE obstacle shifts to the right two tiles
    document.getElementById('R2C11').style.backgroundColor = '#b46dee';
    document.getElementById('R3C11').style.backgroundColor = '#b46dee';
    document.getElementById('R4C11').style.backgroundColor = '#b46dee';
    
    document.getElementById('R2C9').style.backgroundColor = '#ededed';
    document.getElementById('R3C9').style.backgroundColor = '#ededed';
    document.getElementById('R4C9').style.backgroundColor = '#ededed';
    
    document.getElementById('R2C11').disabled = true;
    document.getElementById('R3C11').disabled = true;
    document.getElementById('R4C11').disabled = true;

    document.getElementById('R2C9').disabled = false;
    document.getElementById('R3C9').disabled = false;
    document.getElementById('R4C9').disabled = false;
}



function observerGridToggleAndObstacleChange(id) {
    //toggle grid colour as usual
    gridToggle(id);
    
    //PINK obstruction slides across to the right by one tile
    document.getElementById('R5C12').style.backgroundColor = '#ee6d89';
    document.getElementById('R5C6').style.backgroundColor = '#ededed';
    
    document.getElementById('R5C12').disabled = true;
    document.getElementById('R5C6').disabled = false;
    
    //BLUE obstruction slides upward by one tile
    document.getElementById('R2C5').style.backgroundColor = '#6dc5ee';
    document.getElementById('R7C5').style.backgroundColor = '#ededed';
    
    document.getElementById('R2C5').disabled = true;
    document.getElementById('R7C5').disabled = false;
    
    //PURPLE obstacle shifts to the right two tiles
    document.getElementById('R2C11').style.backgroundColor = '#b46dee';
    document.getElementById('R3C11').style.backgroundColor = '#b46dee';
    document.getElementById('R4C11').style.backgroundColor = '#b46dee';
    
    document.getElementById('R2C9').style.backgroundColor = '#ededed';
    document.getElementById('R3C9').style.backgroundColor = '#ededed';
    document.getElementById('R4C9').style.backgroundColor = '#ededed';
    
    document.getElementById('R2C11').disabled = true;
    document.getElementById('R3C11').disabled = true;
    document.getElementById('R4C11').disabled = true;

    document.getElementById('R2C9').disabled = false;
    document.getElementById('R3C9').disabled = false;
    document.getElementById('R4C9').disabled = false;
    
    //both ORANGE obstructions slide to the right by one tile
    document.getElementById('R1C4').style.backgroundColor = '#ee946d';
    document.getElementById('R2C4').style.backgroundColor = '#ee946d';
    document.getElementById('R3C4').style.backgroundColor = '#ee946d';
    
    document.getElementById('R1C3').style.backgroundColor = '#ededed';
    document.getElementById('R2C3').style.backgroundColor = '#ededed';
    document.getElementById('R3C3').style.backgroundColor = '#ededed';
    
    document.getElementById('R1C4').disabled = true;
    document.getElementById('R2C4').disabled = true;
    document.getElementById('R3C4').disabled = true;

    document.getElementById('R1C3').disabled = false;
    document.getElementById('R2C3').disabled = false;
    document.getElementById('R3C3').disabled = false;

    document.getElementById('R1C8').style.backgroundColor = '#ee946d';
    document.getElementById('R2C8').style.backgroundColor = '#ee946d';
    document.getElementById('R3C8').style.backgroundColor = '#ee946d';
    
    document.getElementById('R1C7').style.backgroundColor = '#ededed';
    document.getElementById('R2C7').style.backgroundColor = '#ededed';
    document.getElementById('R3C7').style.backgroundColor = '#ededed';
    
    document.getElementById('R1C8').disabled = true;
    document.getElementById('R2C8').disabled = true;
    document.getElementById('R3C8').disabled = true;

    document.getElementById('R1C7').disabled = false;
    document.getElementById('R2C7').disabled = false;
    document.getElementById('R3C7').disabled = false;
}

function finishTileReached() {
    alert('Congratulations! Your team has successfully navigated the maze and made it safely to the end!');
}
        

