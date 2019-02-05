<?php

$name = $_POST['user_name'];
$phone = $_POST['user_phone'];
$mail = $_POST['user_mail'];

$name = htmlspecialchars($name);
$phone = htmlspecialchars($phone);
$mail = htmlspecialchars($mail);

$name = urldecode($name);
$phone = urldecode($phone);
$mail = urldecode($mail);

$name = trim($name);
$phone = trim($phone);
$mail = trim($mail);


if (mail("madiktur99@mail.ru", "Заявка с сайта", "Имя: ".$name.". Phone: ".$phone.". Email: ".$mail ,"From: 	zayavka95@stroi-rek.kz \r\n"))
{ 
    header('location: index.html');
}
else 
{ 
    echo "при отправке сообщения возникли ошибки"; 
}

?>