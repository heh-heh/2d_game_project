# 2d_game_project

개인 적으로 포폴용으로 만드는 중인 프로젝트


* * *
### 간단한 스토리

이제막 중학교에서 온라온 한 학생이 고등학교로 진학을 하게 된다
앞으로 3년 동안 여러 학생들과 선생님들로 부터 살아 남아 최종적으로
졸업을 목표로 하게 된다.
* * *

###기본 능력

체력 : 50

이동 속도 : 3

발사 속도 : 0.1S




### 몬스터 - 데미지

일반 학생 - 10

달리는 학생  - 5

덩치큰 학생 - 30

사고 치는 학생 - 15

보스 - 즉사


### 필드에 랜덤으로 떨어진 템

초록병 - 먹으면 일정 시간 무적(화면 어지러움)

xp - exp 증가

급식판 - hp힐


### 패시브(증가)

수자쌤 - 체력(0.1) - 

동균쌤 - 발사 속도(0.02)-제군들 빨리빨리 합시다

용남쌤 - 이속(0.2) - 

교장쌤 - 즉사율(0.01) - 

교감쌤 - 뎀지(0.15) -

성욱쌤 - 획복량 증가  

### 아이템

하이바 - 최대 채력 증가

드럼 스틱 - 물리 데미지 증가

마법 봉 - 마법 데미지 증가, 물리 데미지 추가

마이크 - 즉사율 증가(0.01)

키보드 - 이속, 스킬쿨 감소

산업용 로봇 - 그리퍼 갯수 증가

전기선 - 전기 필드 증가

드라이버 - 드라이버 스킬 갯수 증가

스피커 - beep 데미지 증가

퍽 종합 셋트 - 큰퍽과 작은 퍽의 갯수 증가

랜서 - 작은퍽 데미지 증가

그립퍼 - 근퍽 갯수 증가, 속도 증가

다이너마이트 - 폭탄의 데미지 증가

드론 - 소환 되는 드론수 증가

강화된 나사 - 전동 드릴 데미지 증가

강화된 드론 날 - 날개 데미지 증가


### 마법


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
