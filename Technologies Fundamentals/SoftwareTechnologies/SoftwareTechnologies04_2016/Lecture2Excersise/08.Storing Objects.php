<?php
if (isset($_GET['input'])&&isset($_GET['delimiter']))
{
    $input = $_GET['input'];
    $delimiter = $_GET['delimiter'];

    $arr=explode("\n",$input);
    $arr =array_map('trim',$arr);


    for ($i=0;$i<count($arr);$i++)
    {
        $pairs = explode($delimiter,$arr[$i]);
        $name = $pairs[0];
        $age = $pairs[1];
        $grade = doubleval($pairs[2]);

        echo '<ul>';
        echo '<li>Name: '.$name.'</li>';
        echo '<li>Age: '.$age.'</li>';
        echo '<li>Grade: '.$grade.'</li>';
        echo '</ul>';

    }

}