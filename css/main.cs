@charset "UTF-8";
header .navbar-top {
  height: 112px;
  width: 100%;
  background-color: #0D0D0D;
  position: relative;
  top: 0;
  left: 0; }
  header .navbar-top .navbar-bottom {
    position: absolute;
    height: 72px;
    width: 100%;
    top: 40px;
    left: 0;
    background-color: #FAFAFA;
    box-shadow: 0px 8px 22px -6px rgba(24, 39, 75, 0.12), 0px 14px 64px -4px rgba(24, 39, 75, 0.12); }
    header .navbar-top .navbar-bottom .navbar_menu {
      display: flex;
      justify-content: space-between;
      align-items: center; }
      header .navbar-top .navbar-bottom .navbar_menu .navbar_menu_left {
        display: flex;
        justify-content: space-between;
        align-items: center; }
        header .navbar-top .navbar-bottom .navbar_menu .navbar_menu_left .bars_icon {
          display: none;
          width: 28px;
          height: 22px; }
          header .navbar-top .navbar-bottom .navbar_menu .navbar_menu_left .bars_icon img {
            width: 100%; }
        header .navbar-top .navbar-bottom .navbar_menu .navbar_menu_left .nav_menu_center {
          display: flex;
          justify-content: space-between;
          align-items: center;
          margin-left: 80px;
          padding-top: 8px; }
          header .navbar-top .navbar-bottom .navbar_menu .navbar_menu_left .nav_menu_center li {
            list-style: none;
            margin-right: 25px;
            border-bottom: 3px solid transparent;
            padding-bottom: 8px;
            transition: 0.3s linear; }
            header .navbar-top .navbar-bottom .navbar_menu .navbar_menu_left .nav_menu_center li:first-child {
              border-bottom: 3px solid #000; }
            header .navbar-top .navbar-bottom .navbar_menu .navbar_menu_left .nav_menu_center li:last-child {
              margin-right: 0; }
            header .navbar-top .navbar-bottom .navbar_menu .navbar_menu_left .nav_menu_center li:hover {
              border-bottom: 3px solid #000; }
            header .navbar-top .navbar-bottom .navbar_menu .navbar_menu_left .nav_menu_center li a {
              text-decoration: none;
              color: #000; }
        header .navbar-top .navbar-bottom .navbar_menu .navbar_menu_left .nav_logo {
          display: none;
          width: 42px;
          height: 42px;
          margin-left: 20px; }
          header .navbar-top .navbar-bottom .navbar_menu .navbar_menu_left .nav_logo img {
            width: 100%; }
      header .navbar-top .navbar-bottom .navbar_menu .nav_menu_right {
        display: flex;
        justify-content: space-between;
        align-items: center;
        position: relative;
        right: 45px; }
        header .navbar-top .navbar-bottom .navbar_menu .nav_menu_right .nav_menu_basket li {
          list-style: none !important; }
        header .navbar-top .navbar-bottom .navbar_menu .nav_menu_right li {
          list-style: none;
          margin-right: 25px; }
          header .navbar-top .navbar-bottom .navbar_menu .nav_menu_right li:last-child {
            margin-right: 0; }
          header .navbar-top .navbar-bottom .navbar_menu .nav_menu_right li a {
            text-decoration: none;
            color: #000; }
          header .navbar-top .navbar-bottom .navbar_menu .nav_menu_right li .btn {
            border-radius: 4px;
            padding: 8px 16px;
            text-align: center;
            font-style: normal;
            font-size: 16px;
            display: inline-block; }
          header .navbar-top .navbar-bottom .navbar_menu .nav_menu_right li .btn_outline {
            background-color: rgba(0, 0, 0, 0.05); }
          header .navbar-top .navbar-bottom .navbar_menu .nav_menu_right li .btn_secondary {
            background-color: #FFC000; }
      header .navbar-top .navbar-bottom .navbar_menu .nav_menu_basket {
        position: absolute;
        top: 0;
        right: 30px; }
      header .navbar-top .navbar-bottom .navbar_menu .times {
        display: none; }
header .container {
  width: 100%;
  padding: 0 25px;
  margin: 0 auto; }
  header .container .navbar_top_nav {
    display: flex;
    justify-content: flex-start;
    align-items: center; }
    header .container .navbar_top_nav p {
      color: #fff;
      font-size: 10px;
      font-weight: bold;
      cursor: pointer; }
      header .container .navbar_top_nav p:nth-child(2) {
        margin-left: 8px;
        opacity: 0.3; }
        header .container .navbar_top_nav p:nth-child(2):hover {
          opacity: 1;
          transition: 0.5s all linear; }

@media (min-width: 1202px) {
  .container {
    padding: 0 35px;
    width: 1220px !important;
    position: relative; } }
@media (min-width: 1009px) and (max-width: 1201px) {
  .container {
    padding: 0 25px;
    width: 100% !important; }
    .container .nav_menu_center {
      margin-left: 20px !important; }
    .container .nav_menu_right {
      justify-content: flex-start !important; } }
@media (max-width: 1008px) {
  .navbar-top {
    height: 72px !important; }
    .navbar-top .navbar-bottom {
      top: 0 !important;
      box-shadow: none !important;
      background-color: #fff !important; }
      .navbar-top .navbar-bottom .container {
        padding: 0 15px;
        width: 100% !important; }
        .navbar-top .navbar-bottom .container .navbar_menu .nav_brand {
          display: none; }
        .navbar-top .navbar-bottom .container .navbar_menu .bars_icon {
          display: block !important;
          cursor: pointer; }
        .navbar-top .navbar-bottom .container .navbar_menu .nav_logo {
          display: block !important;
          cursor: pointer; }
        .navbar-top .navbar-bottom .container .navbar_menu .nav_logo_no_active {
          display: none !important; }
        .navbar-top .navbar-bottom .container .navbar_menu .nav_menu_center {
          display: none !important; }
        .navbar-top .navbar-bottom .container .navbar_menu .nav_menu_right {
          margin-left: 10px !important; }
          .navbar-top .navbar-bottom .container .navbar_menu .nav_menu_right li {
            display: none; }
        .navbar-top .navbar-bottom .container .navbar_menu .nav_menu_basket {
          position: relative;
          top: 0;
          right: 0; }
        .navbar-top .navbar-bottom .container .navbar_menu .toggle_bars_center {
          display: block !important;
          position: absolute;
          top: 72px;
          left: 0 !important;
          margin-left: 0 !important;
          justify-content: flex-start !important;
          padding-inline-start: 15px !important;
          padding: none !important; }
          .navbar-top .navbar-bottom .container .navbar_menu .toggle_bars_center li {
            border-bottom: none !important;
            margin: 20px 0 !important; }
            .navbar-top .navbar-bottom .container .navbar_menu .toggle_bars_center li:first-child {
              margin-top: 0 !important; }
            .navbar-top .navbar-bottom .container .navbar_menu .toggle_bars_center li:last-child {
              margin-bottom: 0 !important; }
            .navbar-top .navbar-bottom .container .navbar_menu .toggle_bars_center li a {
              font-size: 24px !important;
              font-weight: bold; }
        .navbar-top .navbar-bottom .container .navbar_menu .toggle_bars_right {
          display: block !important;
          position: absolute;
          top: 300px !important;
          left: 0 !important;
          padding-inline-start: 0 !important;
          margin-bottom: 10px !important; }
          .navbar-top .navbar-bottom .container .navbar_menu .toggle_bars_right li {
            display: block !important;
            width: 100%; }
            .navbar-top .navbar-bottom .container .navbar_menu .toggle_bars_right li:first-child {
              position: absolute !important;
              top: 45px; }
            .navbar-top .navbar-bottom .container .navbar_menu .toggle_bars_right li:last-child {
              margin-bottom: 15px !important;
              margin-right: 0 !important; }
            .navbar-top .navbar-bottom .container .navbar_menu .toggle_bars_right li .btn {
              width: 100%;
              text-align: center; }
            .navbar-top .navbar-bottom .container .navbar_menu .toggle_bars_right li .btn_outline {
              width: 100% !important; }
        .navbar-top .navbar-bottom .container .navbar_menu .active {
          display: block; }
        .navbar-top .navbar-bottom .container .navbar_menu .no_active {
          display: none; } }
main .main_one {
  width: 100%;
  height: 788px;
  background-color: #E1AA00;
  z-index: 0; }
  main .main_one .main_section {
    position: relative;
    top: 0;
    left: 0;
    max-width: 1280px;
    width: 100%;
    margin: 0 auto;
    height: 100%;
    display: flex;
    justify-content: flex-start;
    align-items: center;
    z-index: 1; }
    main .main_one .main_section .section_back_img {
      background-image: url("../img/girl-image.svg");
      height: 100%;
      width: 512px;
      z-index: 888;
      background-position: center center;
      background-repeat: no-repeat;
      background-size: cover;
      position: absolute;
      top: 0;
      right: 20px; }
    main .main_one .main_section .section_black {
      height: 396px;
      background-color: #000;
      width: 100% !important;
      z-index: 88;
      position: absolute;
      top: 203px;
      left: 0; }
      main .main_one .main_section .section_black .section_text {
        width: 588px;
        color: #fff;
        margin-top: 30px; }
        main .main_one .main_section .section_black .section_text h1 {
          font-size: 34px;
          font-weight: 700;
          letter-spacing: 0.25px; }
        main .main_one .main_section .section_black .section_text p {
          font-size: 14px;
          font-weight: 500;
          margin: 16px 24px 0 0; }
        main .main_one .main_section .section_black .section_text p:last-child {
          color: #FFC000;
          font-weight: 600; }
          main .main_one .main_section .section_black .section_text p:last-child::before {
            content: url("../img/Polygon 1.png");
            margin-right: 4px;
            width: 8px;
            height: 8px; }
    main .main_one .main_section .slider_dod {
      position: absolute;
      bottom: 20px;
      left: 50%;
      z-index: 5555;
      margin: 0 auto; }
      main .main_one .main_section .slider_dod .slider {
        padding: 0;
        margin: 0;
        width: 130px;
        height: 32px;
        display: flex;
        justify-content: flex-start;
        align-items: center; }
        main .main_one .main_section .slider_dod .slider li {
          width: 32px;
          height: 32px;
          list-style: none;
          border-radius: 50%;
          display: flex;
          justify-content: center;
          align-items: center;
          cursor: pointer; }
          main .main_one .main_section .slider_dod .slider li:first-child {
            border: 1px solid #000; }
            main .main_one .main_section .slider_dod .slider li:first-child a {
              opacity: 1 !important; }
          main .main_one .main_section .slider_dod .slider li a {
            width: 8px;
            height: 8px;
            border-radius: 50%;
            background-color: #000;
            opacity: 0.3; }

@media (min-width: 1011px) and (max-width: 1201px) {
  .main_one {
    height: 658px; }
    .main_one .main_section .section_back_img {
      height: 100% !important;
      width: 510px !important; }
    .main_one .main_section .section_black .section_text {
      width: 500px !important; }
      .main_one .main_section .section_black .section_text h1 {
        font-size: 30px !important; }
    .main_one .main_section .slider_dod {
      left: 37.5% !important; } }
@media (min-width: 450px) and (max-width: 1008px) {
  .main_one {
    width: 100% !important;
    height: 500px !important; }
    .main_one .section_back_img {
      height: 450px !important;
      width: 295px !important;
      top: 50px !important;
      right: 20px !important; }
    .main_one .slider_dod {
      height: 130px !important;
      width: 34px !important;
      top: 50% !important;
      left: 20px !important; }
      .main_one .slider_dod .slider {
        display: block !important; }
    .main_one .section_black {
      margin-top: 296px !important;
      background-color: #F2F3F7 !important; }
      .main_one .section_black .section_text {
        margin: 30px 20px !important;
        width: 92% !important; }
        .main_one .section_black .section_text h1 {
          color: #000 !important;
          font-size: 45px !important;
          margin: 0 !important;
          padding: 0 !important;
          line-height: 50px !important; }
        .main_one .section_black .section_text p {
          color: #000 !important;
          font-size: 20px !important;
          color: #000 !important;
          font-weight: 500 !important; }
          .main_one .section_black .section_text p:last-child::before {
            content: url("../img/play_black.svg") !important;
            padding-bottom: 5px !important;
            width: 16px !important;
            height: 16px !important; }

  .mt_after_nav {
    margin-top: 350px !important; } }
@media (max-width: 450px) {
  .main_one {
    width: 100% !important;
    height: 311px !important; }
    .main_one .section_back_img {
      height: 260px !important;
      width: 170px !important;
      top: 51px !important;
      right: 5px !important; }
    .main_one .slider_dod {
      height: 100px !important;
      width: 26px !important;
      top: 50% !important;
      left: 20px !important; }
      .main_one .slider_dod .slider {
        display: block !important; }
        .main_one .slider_dod .slider li {
          width: 25px !important;
          height: 25px !important; }
    .main_one .section_black {
      margin-top: 108px !important;
      background-color: #F2F3F7 !important;
      height: 155% !important; }
      .main_one .section_black .section_text {
        margin: 30px 0px  0 20px !important;
        width: 92% !important; }
        .main_one .section_black .section_text h1 {
          color: #000 !important;
          font-size: 32px !important;
          margin: 0 !important;
          padding: 0 !important;
          line-height: 50px !important; }
        .main_one .section_black .section_text p {
          color: #000 !important;
          font-size: 14px !important;
          color: #000 !important;
          font-weight: 500 !important; }
          .main_one .section_black .section_text p:last-child::before {
            content: url("../img/play_black.svg") !important;
            padding-bottom: 5px !important;
            width: 16px !important;
            height: 16px !important; }

  .mt_after_nav {
    margin-top: 350px !important; } }
.main_two {
  background-color: #e5e5e5; }
  .main_two .container {
    max-width: 1240px;
    margin: 0 auto !important;
    padding: 20px; }
    .main_two .container .main_two_header {
      padding: 88px 0 24px 0; }
      .main_two .container .main_two_header h1 {
        text-align: center;
        padding: 0;
        margin: 0; }
    .main_two .container .main_two_box {
      display: flex;
      justify-content: space-between;
      align-items: center;
      flex-wrap: wrap; }
      .main_two .container .main_two_box .box {
        border-radius: 12px;
        width: 294px;
        height: 145px;
        text-align: center;
        background-color: #fff; }
        .main_two .container .main_two_box .box:nth-child(2) {
          margin: 20px; }
        .main_two .container .main_two_box .box img {
          margin-top: 26px;
          width: 24px;
          height: 24px; }
        .main_two .container .main_two_box .box p {
          margin-top: 45px;
          font-size: 16px;
          font-weight: 400; }
    .main_two .container .main_two_cards {
      display: flex;
      justify-content: space-between;
      align-items: center;
      flex-wrap: wrap; }
      .main_two .container .main_two_cards .card {
        width: 264px;
        border-radius: 12px;
        box-shadow: 0px 0px 98px rgba(0, 0, 0, 0.05);
        background-color: #fff;
        margin: 20px 0; }
        .main_two .container .main_two_cards .card .card_img {
          width: 264px;
          height: 337px;
          border-radius: 12px 12px 0 0; }
        .main_two .container .main_two_cards .card .card_body {
          width: 264px;
          border-radius: 0 0 12px 12px;
          padding: 0 12px 0 13px; }
          .main_two .container .main_two_cards .card .card_body h5 {
            font-size: 14px;
            text-transform: uppercase;
            font-weight: 600; }
          .main_two .container .main_two_cards .card .card_body p {
            margin: 8px 0 4px 0;
            font-size: 12px;
            font-weight: 500; }
          .main_two .container .main_two_cards .card .card_body .line_star {
            display: flex;
            justify-content: space-between;
            align-items: center; }
            .main_two .container .main_two_cards .card .card_body .line_star span {
              font-weight: 600;
              font-feature-settings: 'pnum' on, 'lnum' on; }
            .main_two .container .main_two_cards .card .card_body .line_star p {
              text-transform: uppercase;
              font-weight: 600;
              font-size: 10px; }
          .main_two .container .main_two_cards .card .card_body .card_btn {
            text-align: center;
            background-color: #FFC000;
            font-weight: 600;
            font-size: 14px;
            margin: 8px 0;
            padding: 8px 16px;
            border-radius: 6px; }
    .main_two .container .finally {
      margin-top: -24px; }
      .main_two .container .finally h1 {
        margin: 0;
        padding: 0; }
    .main_two .container .main_two_cards_ {
      display: flex;
      justify-content: space-between;
      align-items: center;
      flex-wrap: wrap; }
      .main_two .container .main_two_cards_ .card_img_ {
        margin: 20px 10px;
        position: relative;
        text-align: center;
        cursor: pointer; }
        .main_two .container .main_two_cards_ .card_img_::after {
          content: "Женская обувь";
          position: absolute;
          bottom: 0;
          left: 0;
          display: flex;
          justify-content: center;
          align-items: center;
          text-align: center;
          margin: auto;
          width: 100%;
          height: 78px;
          background: #0D0D0D;
          color: #FFC000;
          border-radius: 0 0 8px 8px;
          font-weight: 700;
          font-size: 24px;
          transition: .5s all linear;
          transform: translateY(22px);
          opacity: 0; }
        .main_two .container .main_two_cards_ .card_img_:hover::after {
          transform: translateY(0);
          opacity: 1;
          transition: .5s all linear; }
        .main_two .container .main_two_cards_ .card_img_:first-child::after {
          transform: translateY(0);
          opacity: 1; }

.main_footer_one {
  height: 576px;
  width: 100%;
  background-color: #ededed; }

* {
  box-sizing: border-box;
  font-family: 'Montserrat', sans-serif;
  list-style: none !important;
  user-select: none !important; }

body {
  padding: 0;
  margin: 0; }

/*# sourceMappingURL=main.cs.map */
