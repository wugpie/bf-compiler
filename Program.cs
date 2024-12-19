//input 받기
string? input = Console.ReadLine();

//가변 배열
List<int> pointer = [];

//초기 값 넣기
pointer.Add(0);

//위치 변수
int loc = 0;

if(input == string.Empty || input == null){
    Console.WriteLine("입력한 정보가 없습니다");
    Environment.Exit(0);
}

foreach (var x in input) {
    switch(x){
        case '+':
            pointer[loc] += 1;
            break;
        case '>':
            loc += 1;
            if(pointer.Count < loc + 1) {pointer.Add(0);}
            break;
        case '<':
            if(loc > 0){loc -= 1;}
            break;
        case '.':
            Console.Write(Convert.ToChar(pointer[loc]));
            break;
    }
}

//마지막 문자 오류 제거
Console.Write(Environment.NewLine);