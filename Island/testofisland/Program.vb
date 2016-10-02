'
' Created by SharpDevelop.
' User: zbysi_000
' Date: 01/10/2016
' Time: 15:31
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Module Program
	Sub Main()
		
	'Dim Fill As Boolean	
	Dim islandArray(89, 59) As Integer
	'Dim toggle As Boolean
	
	For i = 0 To 89 
		For j = 0 To 59 
			islandArray(i, j) = 0
		Next
		
	Next
	
	'(x^2)/(70) + (y^2)/(45) = 1
	
'	Dim lineArray(89,2) As Integer
'	Dim grid(89,59) As Integer
'	
'	For k = 0 To 89 
'		For l = 0 To 59 
'			grid(k, l) = 0
'		Next
'		
'	Next
'	
'	
'	
'	For x = 0 To 89
'		If (-x^2) +80*x -700 > 0 Then
'			lineArray(x,1) = 30 -(+(2/3)*Math.Sqrt((-x^2) +80*x -700))
'			lineArray(x,2) = 30 -(-(2/3)*Math.Sqrt((-x^2) +80*x -700))
'		Else
'			lineArray(x,1) = 0
'			lineArray(x,2) = 0
'		End If
'	Next
'	
'	For x = 0 To 89
'		If lineArray(x,1) <> 0 Then
'			For y = lineArray(x,2) To lineArray(x,1)
'				grid(x,y) = 1
'			Next
'		End If
'	Next
'	
'	For x= 0 To 89
'		For y = 0 To 59
'			Console.Write(grid(x,y))
'		Next
'		Console.WriteLine(vbCrLf)
'	Next
	

'	toggle=false
'	For l = 0 To 89
'		For k = 1 To 59
'			If (islandArray(l, k) = 0 And islandArray(l, k-1) = 2 Then
'				toggle=True
'			End If
''		
'			If toggle=True  Then
'				islandArray(l, k) = 1
'			End If
''		Next
'	Next

'Randomness island generator

	Dim Random As New Random
	
	Dim xRandom As Integer
	xRandom = Random.Next(10, 25+1)	
	Dim yRandom As Integer
	yRandom = Random.Next(10, 16+1)	
		

	For x = 0 To 89
		For y = 0 To 59
			If Math.Floor(((x-40)^2)/(xRandom^2) + ((y-30)^2)/(yRandom^2)) = 1 Then
				islandArray(x, y) = 2
			End If
		Next
	Next
	
	
	
	For l = 0 To 89
		For k = 1 To 29
			If (islandArray(l, k-1) = 2 Or islandArray(l, k-1) = 1) and (islandArray(l, k) = 0) Then
				islandArray(l, k) = 1
			End If
		Next
	Next
	
	For l = 89 To 0 Step-1
		For k = 58 To 30 Step-1
			If (islandArray(l, k+1) = 2 Or islandArray(l, k+1) = 1) and (islandArray(l, k) = 0) Then
				islandArray(l, k) = 1 'grass
			End If
		Next
	Next
	
	'generating some stone
	Dim yStoneRandom As Integer
	Dim xStoneRandom As Integer
	For c = 0 To 100
		yStoneRandom = Random.Next(0, 59)
		xStoneRandom = Random.Next(0, 89)
		If islandArray(xStoneRandom, yStoneRandom) = 1 Then
			islandArray(xStoneRandom, yStoneRandom) = 4 'stone
		End If
	Next
	
	'generating chests
	Dim yChestRandom As Integer
	Dim xChestRandom As Integer
	For c = 0 To 20
		yChestRandom = Random.Next(0, 59)
		xChestRandom = Random.Next(0, 89)
		If islandArray(xChestRandom, yChestRandom) = 1 Then
			islandArray(xChestRandom, yChestRandom) = 6 'chest
		End If
	Next
	
	Dim dungeonBoolean As Boolean = False
	'generating DUNGEON
	Do 
	 
	Dim yDungeonRandom As Integer
	Dim xDungeonRandom As Integer
		yDungeonRandom = Random.Next(0, 59)
		xDungeonRandom = Random.Next(0, 89)
		If islandArray(xDungeonRandom, yDungeonRandom) = 1 And islandArray(xDungeonRandom+1, yDungeonRandom) =1 And islandArray(xDungeonRandom-1, yDungeonRandom) =1 And islandArray(xDungeonRandom, yDungeonRandom+1) =1 And islandArray(xDungeonRandom, yDungeonRandom+2) =1 And islandArray(xDungeonRandom+1, yDungeonRandom+1) =1 And islandArray(xDungeonRandom+1, yDungeonRandom+2) =1 And islandArray(xDungeonRandom-1, yDungeonRandom+1) =1 And islandArray(xDungeonRandom-1, yDungeonRandom+2) =1 Then
			islandArray(xDungeonRandom, yDungeonRandom) = 26 'dungeon
			islandArray(xDungeonRandom+1, yDungeonRandom) = 27
			islandArray(xDungeonRandom-1, yDungeonRandom) = 25
			islandArray(xDungeonRandom, yDungeonRandom+1) = 23
			islandArray(xDungeonRandom, yDungeonRandom+2) = 20
			islandArray(xDungeonRandom+1, yDungeonRandom+1) = 24
			islandArray(xDungeonRandom+1, yDungeonRandom+2) = 21
			islandArray(xDungeonRandom-1, yDungeonRandom+1) = 22
			islandArray(xDungeonRandom-1, yDungeonRandom+2) = 19
			dungeonBoolean = True
		End If
	Loop While dungeonBoolean = False
	
	
	For f = 0 To 89
		For g = 0 To 59
			Console.Write(islandArray(f, g))
		Next
		Console.Write(VBCRLF)
	Next
	
	
		Console.Write("Press any key to continue . . . ")
		Console.ReadKey(True)
	End Sub
End Module
