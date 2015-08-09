alert("ListGetter");

$(function () {
    function getListings() {
        //var id = prompt("Please enter a valid id number", "1");
        $.get('/api/danieloramslistings/5', function (data) {
            alert(data);
            //alert('Retrieved ' + data.length + 'listings.');
            //document.getElementById('Ajax').innerHTML = 'Retrieved ' + data.length + ' listings.';
            //alert(data.getElementsByTagName("ArrayOfDanielOramsListingViewModel"));
            console.log(data);
        });
    }
    $('button[name="btn-listings"]').click(getListings);
    
});

