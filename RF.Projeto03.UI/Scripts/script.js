function DelColab(idColaboradores, nome) {
    var resp = confirm(`Excluir o colaborador '${nome}'?`)
    if (resp) {
        ConfirmDelColab(idColaboradores);
    }
}

function ConfirmDelColab(idColaboradores){
    let xhr = new XMLHttpRequest();
    const url = `/Cadastros/DelColab/${idColaboradores}`

    xhr.onreadystatechange = function () {
        if (this.readyState === 4 && this.status === 404) {
            alert('Colaborador não localizado!')
        }

        if (this.readyState === 4 && this.status === 200) {
            let tr = document.querySelector(`#colab-${idColaboradores}`)
            if (tr !== null) {
                tr.remove()
            }
            alert('Colaborador excluido!')
        }
    }

    xhr.open('get', url)
    xhr.send()
}