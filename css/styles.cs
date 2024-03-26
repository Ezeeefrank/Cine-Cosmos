* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
}

body {
  margin: 0;
}

.corousel .carousel-inner .carousel-item {
  width: 100%;
  max-height: 800px;
}

.h1Carousel {
  font-size: 70px;
  font-weight: 500;
  line-height: 1.2;
  color: #dbedf3;
  text-shadow: 2px 2px 3px black;
}

.carousel-caption {
  top: 500px;
  position: absolute;
  text-align: center;
}
.carousel-caption p {
  margin-bottom: 0.5rem;
  font-weight: 500;
  line-height: 1.2;
  color: #dbedf3;
  text-shadow: 1px 1px 2px black;
}

.horarios {
  font-size: 20px;
}
.horarios span {
  color: #f37066;
}

@media only screen and (min-device-width: 414px) and (max-device-width: 736px) {
  .container {
    max-width: 720px;
  }
  .col-sm-6 {
    flex: 0 0 50%;
    max-width: 50%;
  }
  .col-sm-5 {
    flex: 0 0 41%;
    max-width: 41%;
  }
}
header {
  width: 100%;
}
header img {
  margin: 10px;
  border-radius: 50%;
}
header a {
  text-decoration: none;
  color: #dbedf3;
}
header .nav-item {
  padding: 20px;
}
header .nav-item .nav-link {
  color: #dbedf3;
}

.wrapper-seccion {
  display: block;
  margin: 50px;
  margin-top: 100px;
  margin-left: 50px;
  margin-right: 50px;
}

.titulo-seccion {
  margin: 2%;
  color: #dbedf3;
  margin-left: 10px;
  margin-right: 5px;
}

.col .card {
  position: relative;
  display: flex;
  flex-direction: column;
  border: 1px solid #dbedf3 0, 0, 0, 0.125;
  border-radius: 0.25rem;
}
.col .card .card-img-top {
  object-fit: cover;
  width: 100%;
}
.col .card img {
  vertical-align: middle;
  border-style: none;
}
.col .card .card-body {
  padding: 10px 20px;
}
.col .card .card-title {
  color: #dbedf3;
}
.col .card .card-footer {
  text-align: center;
}
.col .card .card-footer a {
  color: #f37066;
  text-decoration: none;
  text-align: center;
}
.col .card .card-footer a :hover {
  color: #dbedf3;
}
.col .card .card-footer p {
  text-align: center;
}
.col .card .card-footer p span {
  color: #dbedf3;
}

.lightText {
  color: #747678;
}

.primerfooter {
  padding: 50px;
  display: block;
}
.primerfooter .como-llegar {
  text-align: center;
}
.primerfooter .como-llegar .titulo-seccion {
  margin-left: 20px;
}
.primerfooter .como-llegar .locacion a {
  color: #f37066;
  text-decoration: none;
  text-align: center;
}
.primerfooter .como-llegar .locacion a :hover {
  color: #dbedf3;
}

.container {
  width: 100%;
}

.segundoFooter {
  margin-right: 60px;
  margin-left: 50px;
  justify-content: center;
  align-items: center;
}
.segundoFooter .container-footer {
  width: 100%;
  margin: 5%;
  flex-wrap: wrap;
}
.segundoFooter .container-footer .justify-content-start {
  justify-content: flex-start;
}
.segundoFooter .container-footer .justify-content-start .redes {
  display: inline-block;
  vertical-align: baseline;
  margin-left: 8px;
  margin: 10px;
}
.segundoFooter .container-footer .justify-content-start .redes a {
  padding: 10px;
}
.segundoFooter .container-footer .justify-content-start .redes i {
  color: #dbedf3;
}

@media (min-width: 992px) {
  .container {
    max-width: 960px;
  }
}
.container-historia {
  width: 100%;
}

.seccion-historia {
  margin: 20px;
  margin-left: 50px;
  margin-right: 50px;
}

.img-portada {
  overflow: hidden;
  height: 300px;
}

.img-portada img {
  vertical-align: middle;
  border-style: none;
}

img {
  vertical-align: middle;
  border-style: none;
}

.container-historia span {
  color: #f37066;
}
.container-historia a {
  color: #f37066;
}
.container-historia a :hover {
  color: #dbedf3;
}

/*# sourceMappingURL=styles.cs.map */
