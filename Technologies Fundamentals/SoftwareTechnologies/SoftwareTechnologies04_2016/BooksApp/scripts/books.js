const kinveyAppID='kid_rJnQwTWI';
const kinveyServiceBaseUrl = 'https://baas.kinvey.com/';
const kinveyAppSecret = '360fd154824f499788dd2865bbd03189';
function showView(viewId) {
    $("main>section").hide();
$("#"+ viewId).show();
}
function showHideNavigationLinks() {
    let loggedIn = sessionStorage.authToken !=null;
    if(loggedIn){

        $("#linkLogin").hide();
        $("#linkRegister").hide();
        $("#linkListBooks").show();
        $("#linkCreateBooks").show();
        $("#linkLogout").show();
    }
    else{

        $("#linkLogin").show();
        $("#linkRegister").show();
        $("#linkListBooks").hide();
        $("#linkCreateBooks").hide();
        $("#linkLogout").hide();
    }
}
function showHomeView() {
    showView('viewHome');
}
function showLoginView() {
    showView('viewLogin');
}
function login() {
let authBase64 = btoa(kinveyAppID + ":" +kinveyAppSecret);
    $.ajax({
        method:"POST",
        url: kinveyServiceBaseUrl + "user/" + kinveyAppID + "/login",
        data:{
            username:$("#loginUser").val(),
            password:$("#loginPass").val(),
        },
        headers:{"Authorization":"Basic"+authBase64 },
        success: loginSuccess,
        error: showAjaxError
    });
    function loginSuccess(data,status) {
        let ul =$('<ul>');
        for(let post of data){
            ul.append($('<li>').text(post.title + " -> " + post.body));
        }
        $('body').append(ul);
    }
}
function showAjaxError(data,status){
    let errorMsg = "Error: " + JSON.stringify(data);
    $('#errorBox').text(errorMsg).show();
}
function showRegisterView() {
    showView('viewRegister');
}
function register() {

}
function showListBooksView() {
    showView('viewListBooks');
}
function showCreateBooksView() {
showView('viewCreateBook');
}
function createBook() {

}
function logout() {
alert('logout');
    showHomeView();
}
$(function () {
    $("#linkHome").click(showHomeView);
    $("#linkLogin").click(showLoginView);
    $("#linkRegister").click(showRegisterView);
    $("#linkListBooks").click(showListBooksView);
    $("#linkCreateBooks").click(showCreateBooksView);
    $("#linkLogout").click(logout);

    $("#buttonLogin").click(login);
    $("#buttonRegister").click(register);
    $("#buttonCreateBook").click(createBook);
    showHomeView();
    showHideNavigationLinks();
});