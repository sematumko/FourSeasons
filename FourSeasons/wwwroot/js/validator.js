function validateName(id) {
    if (document.getElementById(id).value.length == 0) {
        document.getElementById(id).placeholder = "Введите имя";
        document.getElementById(id).focus();
        return false;
    }

    return true;
}

function validateText(id) {
    if (document.getElementById(id).value.length == 0) {
        document.getElementById(id).placeholder = "Заполните это поле";
        document.getElementById(id).focus();
        return false;
    }

    return true;
}

function validateEmail(id) {
    var emailFilter = /^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$/;

    if (!emailFilter.test(document.getElementById(id).value) || document.getElementById(id).value.length == 0) {
        document.getElementById(id).value = "";
        document.getElementById(id).placeholder = "Введите email в формате email@example.com";
        document.getElementById(id).focus();
        return false;
    }

    return true;
}

function validatePhone(id) {
    var phoneFilter = /^[+]+[1-9][0-9]{9,12}$/;

    if (!phoneFilter.test(document.getElementById(id).value) || document.getElementById(id).value.length == 0) {
        document.getElementById(id).value = "";
        document.getElementById(id).placeholder = "Введите телефон в формате +79781234567";
        document.getElementById(id).focus();
        return false;
    }

    return true;
}

function validateImage(image) {
    var imgFilter = /\.(?:jp(?:e?g|e|2)|png)$/;

    if (!imgFilter.test(document.getElementById(image).value) || document.getElementById(image).value.length < 5) {
        document.getElementById(image).value = "";
        document.getElementById(image).placeholder = "Введите имя файла в формате name.jpg [jpg, png, jpeg]";
        document.getElementById(image).focus();
        return false;
    }

    return true;
}

function validateTextArea(textarea) {
    if (document.getElementById(textarea).value.length == 0) {
        document.getElementById(textarea).placeholder = "Введите текст";
        document.getElementById(textarea).focus();
        return false;
    }

    return true;
}


function validateDates(start, finish) {
    if (document.getElementById(start).value.length == 0) {
        document.getElementById(start).focus();
        return false;
    }

    if (document.getElementById(finish).value.length == 0) {
        document.getElementById(finish).focus();
        return false;
    }

    if (document.getElementById(finish).value <= document.getElementById(start).value) {
        document.getElementById(finish).focus();
        return false;
    }

    return true;
}

//------------------------------------------------------------------

function validateComments(name, email, textarea) {
    return validateName(name) && validateEmail(email) && validateTextArea(textarea);
}

function validateBooking(name, phone, start, finish) {
    return validateName(name) && validatePhone(phone) && validateDates(start, finish);
}

function validateAddNewsForm(name, textarea, image) {
    return validateName(name) && validateImage(image) && validateTextArea(textarea);
}

function validateContacts(address, email, phoneR, phoneC, vk, inst, fb) {
    return validateText(address) && validateEmail(email) && validateText(phoneR) && validateText(phoneC) && validateText(vk) && validateText(inst) && validateText(fb); 
}