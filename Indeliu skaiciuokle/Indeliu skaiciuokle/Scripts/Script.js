$("#skaiciuoti").click(function (e) {
    e.preventDefault();
    var formData = {
        'suma': $('#suma').val(),
        'terminas': $('#terminas').val(),
        'palukanos': $('#palukanos').val(),
        'indelioTipas': $("#indelioTipas").val(),
        'papildymas': $("#papildymas").val()
    };

    console.log(formData);

    $.ajax({
        type: 'POST', // define the type of HTTP verb we want to use (POST for our form)
        url: 'http://localhost:49273/Home/Skaiciuoti', // the url where we want to POST
        data: formData, // our data object
        dataType: 'json', // what type of data do we expect back from the server
        encode: true
    })
            // using the done promise callback
            .done(function (data) {
                // log data to the console so we can see
                $("#sutaupytaSuma").html(data.rezultatas);
                $("#pranesimas").html(data.rezultatas2);

                // here we will handle errors and validation messages
            });
});


$("#indelioTipas").change(function (){
    if($("#indelioTipas").val() == "terminuotasis")
    {
        $("#papildymas-form-group").hide();
    }
    else
    {
        $("#papildymas-form-group").show();
    }
});