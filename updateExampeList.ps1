Clear-Content exampleList.txt; 
dir -Filter example* -Directory | % { $ex = $_.Name; $desc = gc $_/description.txt; ac exampleList.txt "$ex $desc" }
