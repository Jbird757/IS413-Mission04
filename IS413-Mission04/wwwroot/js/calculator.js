
$("#grade_submission").submit(function (e) {

    //Variables for weights
    let assgWeight = .5;
    let groupWeight = .1;
    let quizWeight = .1;
    let mtWeight = .1;
    let finalWeight = .1;
    let intexWeight = .1;
    let letterGrade = ' ';

    //Numeric Grade is each the sum of each category multiplied by it's weight. Result will be between 0-100 (100 being 100%)
    let numericGrade = parseFloat($('#assign').val()) * assgWeight + parseFloat($('#group').val()) * groupWeight + parseFloat($('#quiz').val()) * quizWeight +
        parseFloat($('#mt').val()) * mtWeight + parseFloat($('#final').val()) * finalWeight + parseFloat($('#intex').val()) * intexWeight;


    //Selects proper letter grade that corresponds to the numeric grade above
    if (numericGrade >= 94) {
        letterGrade = 'A';
    } else if (numericGrade >= 90) {
        letterGrade = 'A-';
    } else if (numericGrade >= 87) {
        letterGrade = 'B+';
    } else if (numericGrade >= 84) {
        letterGrade = 'B';
    } else if (numericGrade >= 80) {
        letterGrade = 'B-';
    } else if (numericGrade >= 77) {
        letterGrade = 'C+';
    } else if (numericGrade >= 74) {
        letterGrade = 'C';
    } else if (numericGrade >= 70) {
        letterGrade = 'C-';
    } else if (numericGrade >= 67) {
        letterGrade = 'D+';
    } else if (numericGrade >= 64) {
        letterGrade = 'D';
    } else if (numericGrade >= 60) {
        letterGrade = 'D-';
    } else {
        letterGrade = 'E';
    }


    alert("Grade: " + letterGrade);
    //Changes value in associated <p> tag in index.html
    //$('#result').text(letterGrade);
})

