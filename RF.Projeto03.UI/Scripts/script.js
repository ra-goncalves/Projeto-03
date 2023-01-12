function DelColab(idColaboradores, nome) {
    //var resp = confirm(`Excluir o colaborador '${nome}'?`)
    //if (resp) {
    //    ConfirmDelColab(idColaboradores);
    //}

    var myModal = new bootstrap.Modal('#delModal', {
        keyboard: false
    })

    var modalToggle = document.getElementById('delModal')
    var modalText = document.getElementById('nomeColabModal')
    modalText.textContent = nome
    modalToggle.dataset.id = idColaboradores
    myModal.show(modalToggle)
}

function ConfirmDelColab() {
    var genericModalEl = document.getElementById('delModal')
    var modal = bootstrap.Modal.getInstance(genericModalEl)
    let idColaboradores = delModal.getAttribute("data-id")
    let xhr = new XMLHttpRequest();
    const url = `/Cadastros/DelColab/${idColaboradores}`

    xhr.onreadystatechange = function () {
        if (this.readyState === 4 && this.status === 404) {
            toastr.error('Colaborador não localizado!', 'Projeto 03')
        }

        if (this.readyState === 4 && this.status === 200) {
            let tr = document.querySelector(`#colab-${idColaboradores}`)
            if (tr !== null) {
                tr.remove()
            }
            delModal.dataset.id = 0
            modal.hide()
            toastr.success('Colaborador excluido com sucesso!', 'Projeto 03')
        }
    }

    xhr.open('get', url)
    xhr.send()
}

let timeout = null;

document.getElementById('ibusca').addEventListener('keyup', function (e) {
    clearTimeout(timeout);

    timeout = setTimeout(function () {
        LiveSearch()
    }, 800);

});

function LiveSearch() {
    let value = document.getElementById('ibusca').value

    if (value != '') {

        $.ajax({
            type: "POST",
            url: "/Shared/Search",
            data: { nomeColab: value },
            datatype: "html",
            success: function (result) {
                $('#result').html(result);
            }
        });
        $('#result').show();
    } else {
        $('#result').hide();
    }


}

/*
const formlogin = document.getElementById("loginform"),
    campoEmail = formlogin.querySelector("#email"),
    dadosEmail = campoEmail.querySelector("input"),
    campoSenha = formlogin.querySelector("#senha"),
    dadosSenha = campoSenha.querySelector("input");

 Vericar email e senha

form.onsubmit = (e) => {
    e.preventDefault();

    if (dadosEmail.value == "") {
        campoEmail.classList.add("shake", "erros");
    } else {
        checarEmail();
    }
    if (dadosSenha.value == "") {
        campoSenha.classList.add("shake", "erros");
    } else {
        campoSenha.classList.remove("erros");
    }

    setTimeout(() => {
        campoEmail.classList.remove("shake");
        campoSenha.classList.remove("shake");
    }, 500);

    dadosEmail.onkeyup = () => {
        checarEmail();
    }

    function checarEmail() {
        let pattern = /^[^ ]+@[^ ]+\.[a-z]{2,3}$/;
        if (!dadosEmail.value.match(pattern)) {
            campoEmail.classList.add("erros");
            let erromsg = campoEmail.querySelector(".erro-msg");
            (dadosEmail.value != "") ? erromsg.innerText = "O email tem que ser valido" : erromsg.innerText = "O email não pode estar em branco";
        } else {
            campoEmail.classList.remove("erros");
        }
    }

    if (!campoEmail.classList.contains("erros") && !campoSenha.classList.contains("erros")) {
        console.log("Sucesso")
    }
}*/