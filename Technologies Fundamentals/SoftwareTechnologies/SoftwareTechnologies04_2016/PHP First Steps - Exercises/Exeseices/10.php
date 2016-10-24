<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>
</head>
<body>
<form>
    N: <input type="text" name="num1"/>
    <input type="submit"/>
</form>

<?php
if (isset($_GET['num1'])) {
    
    $n = intval(intval($_GET['num1']));
    for ($i = $n-1; $i >= 1; $i--) {
        echo $i . " " . '<br>';

    }
}
?>
</body>
</html>