// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

window.onload = function () {

    var xhr = new XMLHttpRequest();
    xhr.open('GET', 'http://localhost:8081/api/city', false);
    xhr.send();

    if (xhr.status != 200) {
        alert(xhr.status + ': ' + xhr.statusText);
    } else {
        var data = JSON.parse(xhr.response);

        var options = '';
        for (var i = 0; i < data.length; i++) {
            options += "<option value='" + data[i].cityID + "'>"
                + data[i].name + "</option>\r\n";
        }

        document.getElementById("city").innerHTML = options
    }
};

function RegistredUser() {

    var RegistrUser = new UserModel({
        fullname: document.getElementById("fullname").value,
        email: document.getElementById("email").value,
        phone: document.getElementById("phone").value,
        cityid: document.getElementById("city").value
    });

    var valid = RegistrUser.IsValid();
    console.log(valid);

    if (valid == true) {
        //var xhr = new XMLHttpRequest();
        //xhr.open("POST", "/api/User", true);
        //xhr.setRequestHeader('Content-Type', 'application/json');
        //xhr.send(JSON.stringify(RegistrUser));
        alert('Данные отправлены в базу данных.')
        ClearData();
    }
    else {
        alert("Данные заполнены не верно!");
    }

}

// Clear Data
function ClearData() {
    document.getElementById("UserForm").reset();
}

// User model
var UserModel = function (content) {
    this.FullName = content.fullname;
    this.Email = content.email;
    this.Phone = content.phone;
    this.CityID = content.cityid;
};

//Model validation function
UserModel.prototype.IsValid = function () {

    var isValid = true;

    if ((!this.FullName.match(/[а-яА-Я]/g) && isValid) || (this.FullName.length < 5 && isValid))
        isValid = false;

    if ((!this.Phone.match(/[1-9]/g) && isValid) || (this.Phone.length < 11 && isValid))
        isValid = false;

    var mailRegex = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/;
    if (!mailRegex.test(this.Email))
        isValid = false;

    if (this.CityID < 1 && isValid)
        isValid = false;

    return isValid;
};


