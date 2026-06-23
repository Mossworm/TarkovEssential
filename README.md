# Tarkov Essential

Tarkov Essential은 Escape from Tarkov 플레이를 도와주는 애플리케이션입니다.

실시간 지도와 유용한 음성 알림을 제공하며, Tarkov Tracker에 퀘스트 진행 상황을 자동으로 업데이트하는 등 여러 편의 기능을 한곳에서 사용할 수 있습니다.

<img src="assets/1.png">


<p>

> [!WARNING]
> 본 프로그램은 [GPL-3.0 라이선스](./LICENSE)로 배포되며, **본 프로그램 사용으로 인한 어떠한 피해(BSG에 의한 제재 등)에 대해서도 책임지지 않습니다.**
> 본 프로그램은 [tarkov.dev](https://tarkov.dev/)과 공식적인 관계가 없으며, [tarkov monitor](https://github.com/the-hideout/TarkovMonitor)를 수정하여 제작되었습니다.

## 설치 방법
1. 이 프로젝트의 [최신 릴리스](https://github.com/Mossworm/TarkovEssential/releases/latest) 페이지로 이동합니다.
2. `Assets` 항목에서 Tarkov Essential 압축 파일을 내려받습니다.
3. 내려받은 압축 파일을 원하는 폴더에 풉니다.
4. 폴더 안의 `TarkovEssential.exe`를 실행합니다.

## 초기 설정
<img src="assets/2.png">
1. 왼쪽 하단에있는 Remote ID를 클릭해 복사합니다.
<p>

<img src="assets/4.png">
2. Setting 에서 복사한 Remote ID를 붙혀넣은 후 아래 토글 3개를 활성화 해줍니다.
<br>
3. 그 후, 타르코프 Logs 폴더 경로도 입력해줍니다.

- 스팀버전 : C:\Program Files (x86)\Steam\steamapps\common\Escape from Tarkov\build\Logs
- 공홈버전 : %LOCALAPPDATA%\Battlestate Games\Escape from Tarkov\Logs

## 사용 방법
<img src="assets/5.png">
타르코프 캡쳐 키를 누르면 Maps 에서 플레이어의  위치가 표시됩니다.

또한, PVP 글씨를 누르면 PVE로 전환할 수 있으며
주요 오브젝트 표시 및 퀘스트 표시가 가능합니다.

## 주요 기능

- 음성 알림
  - 매칭 완료
  - 레이드 시작
  - 실패한 퀘스트 재시작 알림
  - 런스루 시간 경과
  - 에어 필터 켜기/끄기
  - 스캐브 쿨다운
  - 퀘스트 아이템 확인 알림
    - 실제 퀘스트 아이템 보유 여부를 검사하는 기능은 아니며, 매칭을 취소할 수 있도록 알려주는 단순 알림입니다.
  - 위 알림에 사용되는 사운드 변경
- Tarkov.dev 지도
  - 애플리케이션 안에서 Tarkov.dev 지도 확인
  - 플레이 중인 맵의 지도 자동 표시
  - 게임 내 스크린샷을 이용해 지도에 현재 위치 표시
- Tarkov.dev 원격 제어 연동
  - 원격 코드를 이용해 다른 브라우저에 열린 Tarkov.dev 제어
  - 레이드 입장 시 플레이 중인 맵의 지도 자동 표시
- Tarkov Tracker 연동
  - API 토큰을 이용해 Tarkov Tracker 연결
  - 완료한 퀘스트를 Tarkov Tracker에 자동 반영
- 통계
  - 모든 통계는 사용자의 컴퓨터에만 저장됩니다.
  - 플리마켓 총판매액 기록
  - 맵별 플레이 횟수 기록
- 시각적 타이머
  - 레이드 진행 시간 표시
  - 런스루 제한 시간 카운트다운
  - 스캐브 쿨다운 카운트다운