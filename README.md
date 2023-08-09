# 2d_game_project

개인 적으로 포폴용으로 만드는 중인 프로젝트

* * *
#생각 중인 것들

- 스테이지를 1,2,3 학년 으로 나눠서 최종 적으로 학교를 졸업 하는 것이 목표
- 보스 - 각 학년별 대표 과목 쌤
- 일반 몬스터 - 학생 으로 생각 중(덩치큰, 마른, 일반)
- 마법(?)의 경우 아직은 설정만 존재함
- 
경남로봇고 에서 살아 남기

https://app.monopro.org/pixel/
https://www.remove.bg/ko/upload

기본 능력
체력 : 50
이동 속도 : 3
발사 속도 : 0.1S
기본 maxexp : 100 


몬스터
일반 학생 - 10
달리는 학생  - 5
덩치큰 학생 - 30
사고 치는 학생 - 15
보스 (고양이)- 즉사


필드에 랜덤으로 떨어진 템
초록병 - 먹으면 일정 시간 무적
xp - exp 증가
급식판 - hp힐


패시브(증가 율)
수자쌤 - 체력(0.1) - 
동균쌤 - 발사 속도(0.02)-제군들 빨리빨리 합시다
용남쌤 - 이속(0.2) - 
교장쌤 - 즉사율(0.01) - 
교감쌤 - 뎀지(0.15) -
성욱쌤 - 획복량 증가  

아이템
큐브 - 맞춰진 면 갯수에 따라 능력 강화
황철용 쌤의 드럼 스틱 - 데미지 증가
드론의 안전모 - 방어력 증가
수자쌤의 초록 음료 - 기능반 태그 의 마법 데미지 증가


마법


모바일
beep - 일정 시간 마다 울리며 울릴때 마다 일정 거리 안에 들어 올 경우 데이지
큰퍽 - 캐릭터 주번에 일정 거리를 유지 하며 돌면서 데미지(max : ?)
작은 퍽 - 팻 처럼 근체에 생성 되서 같이 총알을 발사 한다

산업용
그립퍼 - 하늘에서 적을 집어서 감 (즉사)
전기 - 일정 주기로 플레이어 주변으로 전기 충격을 중 
전동 드릴 - 총알 대신 나사 발사
드라이버 - 일자로 쭉 가르고 나가며 데미지


드론
날개 - 일정 시간 마다 소화 되며 날 에 다이는 적을 데미지 입힌다
폭탄 - 일정 주기로 하늘에서 폭탄을 떨어 뜨려 스플 데미지
힐(폭탄 lv 3) - 확율적으로 폭탄 대신 힐킷을 주며 체력을 풀피로 회복 한다



* * *
# road map

### 플레이어 스킬
- 아직 설정 정도만 존재 하며 제작 하진 않음

### 몬스터
- 현재 4가지가 존재 하며 실직적으로는 big, speed, 일반 3가지만 출현
- 추후 시간에따라 보스 출현 구현 예정

### 몬스터 스폰 위치 지정
- 몬스터가 스폰은 하나 아직까진 미흡

### 최적화
- 현재는 몬스터가 게속해서 쌓이는 경우가 발생시 어떤 식으로 렉혹은 자원을 소모하는지 모름
- 아이템의 경우 스폰 한뒤 일정 시간뒤 디스폰 하게금 함

### 레벨업 시 선택창 ui
- 레벨업시 선택창이 작동을 하지만 아직 스킬이 없어 무의미함
- 스킬 선택은 스킬을 일부 제작 후 만들 예정

### esc 누를 시 메뉴창 ui
- continew 와 game restet 작동

### 게임 오버 UI
- 아직 미흡 해보임
- 스페이스바 누르면 다시 시작

### 아이템 스폰
- 아이템 제작중
- 식판 : 체력의 15% 힐 (제작 함, 아직 미흡 한점 이 있어 수정이 필요 해 보임)
- 초록음료 : 일정 시간 무적 이후 n 초 만큼 느려짐 (색각중에만 있음)
- exp 잼 or 스톤 or (?) : 아직 어떤 식으로 구현 할지 생각중 아마 소중대 사이즈로 나올 예정
