function GetMovies() {
    var xhr = new XMLHttpRequest()

    xhr.open('GET', 'http://localhost:5006/api/movie', true);

    xhr.send();

    xhr.onload = function () {
        var data = JSON.parse(xhr.response)
        //$.each(data.Movies, function(title, genre, director)){
        var table = $("#table tbody");
        data.forEach(movie => {
            table.append("<tr><td>" + movie.Title + "</td><td>" + movie.Genre + "</td><td>" + movie.DirectorName + "</td></tr>");
        });

    }
}

function doIt() {
    var success;
    var thing = { Title: $("#title")[0].value, Genre: $("#genre")[0].value, DirectorName: $("#director")[0].value };
    var myJSON = JSON.stringify(thing);
    //function Add( e ){
    $.ajax({
        url: 'http://localhost:5006/api/movie',
        dataType: 'json',
        type: 'post',
        headers: { "Content-Type": 'application/json' },
        data: myJSON,
        success: success
    });
}







// (function ($) {
//     $('#newMovie').submit(processForm);

//     function processForm(e) {
//         $.ajax({
//             url: 'http://localhost:5006/api/movie',
//             dataType: 'json',
//             type: 'post',
//             contentType: 'application/json',
//             data: $({Title: this[0].value}).serialize()
//         })


//         e.preventDefault()

//     };
// })(jQuery);


/*var title = $("#title").value;
var genre = document.getElementById("genre").value;
var directorName = document.getElementById("director").value;
var thing = {Title:$("#title").value,Genre:$("genre").value,DirectorName:$("director").value};
//var thing = {Title:title,Genre:genre,DirectorName:directorName};
var myJSON = JSON.stringify(thing);*/
/*(function($){
    function Add(){
        var xhr =new XMLHttpRequest()
        xhr.open('POST','http://localhost:5006/api/movie',true);
        xhr.setRequestHeader('Content-Type', 'application/json');
        xhr.send(JSON.stringify({
            value:thing
        }));
    }
    $("Submit").click( Add );
})(jQuery);*/


/* $("SubmitButton").click( Add );
 function Add(){
     var xhr =new XMLHttpRequest()
     xhr.open('POST','http://localhost:5006/api/movie',true);
     xhr.setRequestHeader('Content-Type', 'application/json');
     xhr.send(JSON.stringify({
         value:thing
     }));
 }*/



/*   $('newMovie').click(function() {
       var thing = {Title:$("#title").value,Genre:$("#genre").value,DirectorName:$("#director").value};
       var myJSON = JSON.stringify(thing);
       $.ajax({
           url: 'http://localhost:5006/api/movie',
           dataType: 'json',
           type: 'post',
           headers:{"Content-Type": 'application/json'},
           data: myJSON,
           success: success
       });
   });*/

/*function thing(){
/*$.get('http://localhost:5006/api/movie',function(){
$(".table").append(data)
})
};*/

/*jQuery.ajax({url: "http://localhost:5006/api/movie",
type: "GET",

contentType: 'application/json; charset=utf-8',
success: function(resultData) {
    //here is your json.
      // process it
      resultData.forEach(movie =>{console.movie.Title})
      //$(".table").append(resultData)
}})};*/