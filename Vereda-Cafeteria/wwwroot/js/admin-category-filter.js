(function () {
    function initCategoryFilter(filterEl) {
        var toggle = filterEl.querySelector('.category-filter-toggle');
        var label = filterEl.querySelector('.category-filter-label');
        var checkboxes = filterEl.querySelectorAll('.category-filter-checkbox');
        var clearBtn = filterEl.querySelector('.category-filter-clear');
        var toolbar = filterEl.closest('.list-toolbar');
        var table = toolbar ? toolbar.nextElementSibling : null;

        if (!table || table.tagName !== 'TABLE') {
            return;
        }

        var rows = table.querySelectorAll('tbody tr[data-categoria-id]');

        function getSelectedIds() {
            return Array.prototype.filter.call(checkboxes, function (cb) {
                return cb.checked;
            }).map(function (cb) {
                return cb.value;
            });
        }

        function applyFilter() {
            var selected = getSelectedIds();

            rows.forEach(function (row) {
                var show = selected.length === 0 || selected.indexOf(row.getAttribute('data-categoria-id')) !== -1;
                row.style.display = show ? '' : 'none';
            });

            if (selected.length === 0) {
                label.textContent = 'Selecione as categorias';
                toggle.classList.remove('active');
            } else if (selected.length === 1) {
                label.textContent = '1 categoria selecionada';
                toggle.classList.add('active');
            } else {
                label.textContent = selected.length + ' categorias selecionadas';
                toggle.classList.add('active');
            }
        }

        toggle.addEventListener('click', function (event) {
            event.stopPropagation();
            filterEl.classList.toggle('open');
        });

        checkboxes.forEach(function (cb) {
            cb.addEventListener('change', function () {
                var item = cb.closest('.category-filter-item');
                if (item) {
                    item.classList.toggle('is-checked', cb.checked);
                }
                applyFilter();
            });
        });

        if (clearBtn) {
            clearBtn.addEventListener('click', function (event) {
                event.stopPropagation();
                checkboxes.forEach(function (cb) {
                    cb.checked = false;
                    var item = cb.closest('.category-filter-item');
                    if (item) {
                        item.classList.remove('is-checked');
                    }
                });
                applyFilter();
            });
        }

        document.addEventListener('click', function (event) {
            if (!filterEl.contains(event.target)) {
                filterEl.classList.remove('open');
            }
        });

        applyFilter();
    }

    function init() {
        document.querySelectorAll('.category-filter').forEach(initCategoryFilter);
    }

    if (document.readyState === 'loading') {
        document.addEventListener('DOMContentLoaded', init);
    } else {
        init();
    }
})();
