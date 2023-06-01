$authors = array(
    "Пушкин" => array("Евгений Онегин", "Капитанская дочка", "Руслан и Людмила"),
    "Толстой" => array("Война и мир", "Анна Каренина", "Хаджи-Мурат"),
    "Достоевский" => array("Преступление и наказание", "Идиот", "Братья Карамазовы")
);

echo "<ul>";
foreach ($authors as $author => $books) {
    echo "<li>$author:";
    echo "<ul>";
    foreach ($books as $book) {
        echo "<li>$book</li>";
    }
    echo "</ul>";
    echo "</li>";
}
echo "</ul>";