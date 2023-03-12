class MyHeader extends HTMLElement {
    connectedCallback() {
        this.innerHTML = ` <header>
        <nav class="navbar navbar-expand-lg navbar-light bg-light">
            <div class="container-fluid" >
                <a class="navbar-brand" href="#"><img src="letter-logo-jd-dj-logo-design-vector-27337796-removebg-preview.png" alt="Logo" width="100px" /></a>
                <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <div class="collapse navbar-collapse" id="navbarSupportedContent">
                    <ul class="navbar-nav me-auto mb-2 mb-lg-0">
                        <li class="nav-item">
                            <a class="nav-link active" aria-current="page" href="#">Home</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="/index.html">Resume</a>
                        </li>
                        <li class="nav-item dropdown">
                            <a class="nav-link dropdown-toggle" href="#" id="navbarDropdown" role="button" data-bs-toggle="dropdown" aria-expanded="false">
                                Portfolio
                            </a>
                            <ul class="dropdown-menu" aria-labelledby="navbarDropdown">
                                <li><a class="dropdown-item" href="#"></a></li>
                                <li><a class="dropdown-item" href="#">Another action</a></li>
                                <li><hr class="dropdown-divider"></li>
                                <li><a class="dropdown-item" href="#">Something else here</a></li>
                            </ul>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link " href="/index.html/#ContactUs" tabindex="-1" ">Contact</a>
                        </li>
                    </ul>

                </div>
            </div>
        </nav>
    </header>`
    }
}
customElements.define('my-header', MyHeader)

class MyFooter extends HTMLElement {
    connectedCallback() {
        this.innerHTML = ` <footer class=" text-center text-lg-start" style="background:#C9EEFF;">
  <!-- Copyright -->
  <div class="text-center p-3" style="background-color:#C9EEFF;">
    © 2020 Copyright:
    <a class="text-dark" href="https://www.facebook.com/">Delson James M. Tubiera</a>
  </div>
  <!-- Copyright -->
</footer> `
    }
}
customElements.define('my-footer', MyFooter)


