function GetMovies(){
    var xhr = new XMLHttpRequest()

    xhr.open('GET', 'http://localhost:5006/api/movie', true);
    
    xhr.send();
    
    xhr.onload = function (){
        var data = JSON.parse(xhr.response)
        //$.each(data.Movies, function(title, genre, director)){
            var table = $("#table tbody");
            data.forEach(movie=>{
                table.append("<tr><td>"+movie.Title+"</td><td>"+movie.Genre+"</td><td>"+movie.DirectorName+"</td></tr>");
            });

    }}

 


function remove(){
    var xhr =new XMLHttpRequest()
    xhr.open('GET','')
}

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