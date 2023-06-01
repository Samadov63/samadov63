<?php
$birthday = $_POST['birthday']; // получаем значение из инпута
$today = date('m/d/Y'); // текущая дата
$diff = strtotime($birthday) - strtotime($today); // вычисляем разницу в секундах
$days_left = round($diff / 86400); // переводим секунды в дни и округляем

echo "До вашего дня рождения осталось: " . $days_left . " дней";
?>

<!-- HTML форма -->
<form method="POST">
  <input type="text" name="birthday" placeholder="Введите дату рождения (дд.мм.гггг)">
  <button type="submit">Узнать сколько дней до дня рождения</button>
</form>
