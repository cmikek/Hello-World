
$(document).ready(function () {

    DisplayMessage();

});

function DisplayMessage() {

    var message = GetMessage();

}

function GetMessage() {

    $.ajax({
        type: 'GET',
        url: webapiurl + "Message",
        contenttype: 'application/json; charset-utf-8',
        dataType: 'json',
        success: function (data) {
            SetMessageText(data.Text);
        },
        failure: function (response) {
            alert('here');
            SetMessageText("Error attempting to get message.");
        }
    });

}

function SetMessageText(msg) {
    $('.messagetext').text(msg);
}