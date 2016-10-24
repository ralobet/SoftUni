<?php
if (isset($_GET['lines'])&&isset($_GET['delimiter']))
{
    $lines = $_GET['lines'];
    $delimiter = $_GET['delimiter'];
    $arr = explode($delimiter,$lines);
    $arr = array_map('trim',$arr);

    for ($i=0;$i<count($arr);$i++)
    {
        if ($arr[$i]=='Stop')
        {
            break;
        }
        else
        {
            echo $arr[$i].'<br>';
        }
    }
}