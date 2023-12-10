
    //Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.
        string abc = "Our online English Classes FEature lotS of usefUl learNing matErials ";

        string result = string.Empty;
        string resultup = string.Empty;
 
        for ( int i = 0; i < abc.Length; i++ )
            if ( char.IsUpper( abc[ i ] ) )
                result += char.ToLower( abc[ i ] );
            else
                result += char.ToLower( abc[ i ] );
 
        Console.WriteLine( result );
        
        Console.ReadKey( true );
    

