<?php
if(isset($_GET['numbers'])&&isset($_GET['delimiter']))
{
    $delimiter = $_GET['delimiter'];
    $lines = $_GET['numbers'];

    $arr = explode($delimiter,$lines);
    $arr = array_map('trim',$arr);

    for($i=count($arr)-1;$i>=0;$i--)
    {
       echo $arr[$i].'<br>';
    }
}

