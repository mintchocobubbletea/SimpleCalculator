# (C# 코딩) 심플 사칙연산기
## 개요
- C# 프로그래밍 학습
- 1줄 소개: 사칙연산을 수행하는 계산기 프로그램
- 핵심기능: 사칙연산 기능, C, CE, Del 기능,  
- 화면구성: Label(프로그램 제목, 현재 대화 개수), Textbox, button(사칙연산 기능)
- 사용한 플랫폼: 
	- C#, .NET Windows Forms, Visual Studio, GitHub
- 사용한 컨트롤:
	- Label, TextBox, Button
- 사용한 기술과 구현한 기능:
	- Visual Studio를 이용하여 UI 디자인
	- string 클래스를 이용한 사용자 입력 데이터 처리
	- 

## 실행 화면 (과제1)
- 과제1 코드의 실행 스크린샷
<img width="439" height="629" alt="과제 1" src="https://github.com/user-attachments/assets/cf88285d-1965-44ca-be72-211fc4d33e11" />


- 과제 내용
	- TextBox(입력표시, 결과표시), Button(계산) 등을 적절히 배치합니다.
	- 숫자 Button 클릭 시 TextBox에 표시합니다. 
	- 2개의 피연산자의 입력값을 Int로 바꾸어 더하기 계산을 수행하고 그 결과를 저장합니다.
	- 계산 결과 값을 문자열로 변환하여 표시합니다. 
- 구현 내용과 기능 설명
	- 숫자 버튼 클릭시 입력창에 숫자들이 표시됨
	- 전체 식은 결과 창에 모두 표시됨
	- 입력창에는 숫자들만 표시됨
- 사용한 기술과 구현한 기능:
	- button과 textbox 툴들을 이용하여 UI 디자인
	- 이벤트 메소드들을 툴들과 연결하여 기능 구현
	- 구현하려는 기능들에 필요한 변수들을 추가

## 실행 화면 (과제2)
- 과제2 코드의 실행 스크린샷

<img width="438" height="621" alt="과제 2_3" src="https://github.com/user-attachments/assets/86b31769-550f-4deb-8159-67e969740eaa" />
<img width="434" height="624" alt="과제 2_2" src="https://github.com/user-attachments/assets/ee815f64-7157-426c-94d2-dd6a3d32141f" />
<img width="433" height="630" alt="과제 2" src="https://github.com/user-attachments/assets/5d4469d6-3e84-4389-9476-b8ed940016e0" />

- 과제 내용
	- 뺄셈(-), 곱셈(*), 나눗셈(/) 버튼 추가
	- 각 버튼들에 맞는 이벤트 연결
	- 각 버튼 클릭 시 연산자만 변경하여 동일한 로직이 적용되도록 함
- 구현 내용과 기능 설명
	- 필요한 연산자들을 위한 버튼 추가
	- 추가한 버튼들의 이름 재설정
	- 추가한 연산자들에 필요한 이벤트 추가함
	- 추가한 이벤트들과 연산자들 연결함.
- 사용한 기술과 구현한 기능:
	- button들을 추가하여 연산자 지정
	- 이벤트 메소드들을 툴들과 연결하여 기능 구현
	- 적절한 메소드들과 변수를 이용하여 동일한 로직으로 작동하도록 함

## 실행 화면 (과제3)
- 과제3 코드의 실행 스크린샷
<img width="439" height="626" alt="과제 3" src="https://github.com/user-attachments/assets/5b1b57c8-0886-443b-9725-5ac3b8e47c94" />
<img width="436" height="623" alt="과제 3_3" src="https://github.com/user-attachments/assets/8840fbc4-3428-4a8f-81c9-48afc9c1ded8" />
<img width="435" height="626" alt="과제 3_2" src="https://github.com/user-attachments/assets/afd790d2-aee9-4b6b-b7c7-b70649dab196" />


- 과제 내용
	- 버튼 C 추가 및 기능 구현함
	- 버튼 CE 추가 및 기능 구현함
	- 버튼 Del 추가 및 기능 구현함
- 구현 내용과 기능 설명
	- 현재의 모든 내용을 삭제하고 처음 (초기화된) 상태로 되돌아가는 C 버튼 구현함
	- 마지막 입력한 피연산자(Operand) 값을 삭제하는 CE 버튼 구현함
	- 마지막 입력된 글자 하나 (숫자 하나) 값을 삭제하는 Del 버튼 구현함
- 사용한 기술과 구현한 기능:
	- trim() 함수를 이용해 입력값 다듬음
	- 각 기능들에 필요한 버튼들을 추가했음
	- 버튼들에 알맞은 이벤트들을 구현하고 연결했음

## 실행 화면 (과제4)
- 과제4 코드의 실행 스크린샷
<img width="437" height="628" alt="과제4" src="https://github.com/user-attachments/assets/8c497d3b-c7ce-4acb-88bf-06131d28aeec" />
<img width="432" height="625" alt="과제 4_2" src="https://github.com/user-attachments/assets/26ea6ce8-e8b6-4776-8ed3-88ef4c7aa30b" />
<img width="687" height="625" alt="과제4_4" src="https://github.com/user-attachments/assets/a0f2025a-31be-4cad-89d2-c8d7db2b25f3" />
<img width="685" height="627" alt="과제4_3" src="https://github.com/user-attachments/assets/93c7e9fb-f107-42ae-8c43-9d897f6e35ee" />


- 과제 내용
	- +/- 버튼 추가 및 기능 구현
	- 소수점 . 버튼 추가 및 기능 구현
	- 키보드로도 계산기 입력 가능하게 기능 구현
	- 계산기록 구현
	- 괄호 버튼 추가 및 기능 구현

- 구현 내용과 기능 설명
	- 이전 버튼들과 동일하게 +/- 버튼과 . 버튼 클릭 시 동일하게 동작하게 구현
	- 키보드 입력 이벤트 메소드를 추가하여 키보드 입력으로도 동작하게 구현
	- Listbox를 추가하여 검색한 기록 남게 구현 함
	- 괄호 버튼 추가 후 기능 이벤트 메소드 구현 후 연결함

- 사용한 기술과 구현한 기능:
	- Listbox를 추가하여 결과값이 박스에 추가되도록 함
	- 키보드 이벤트 메소드를 연결하여 키보드 입력 기능 구현
	- 부호를 변경하는 이벤트 메소드를  +/-버튼과 연결하였고 . 소수점 버튼 계산 기능 구현
	- 괄호 버튼 이벤트를 키보드 입력 기능도 추가하여 구현함

