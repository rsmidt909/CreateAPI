function doIt(){
    var xhr = new XMLHttpRequest()

    xhr.open('GET', 'http://localhost:5006/api/movie', true);
    
    xhr.send();
    
    xhr.onload = function (){
        var data = JSON.parse(xhr.response)
        data.forEach(movie =>{
            console.log(movie.Title);
        })
    }
}
function remove(){
    var xhr =new XMLHttpRequest()
    xhr.open('GET','')
}
